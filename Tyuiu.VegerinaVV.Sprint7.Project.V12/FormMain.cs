using System.IO;
using System.Xml;
using Tyuiu.VegerinaVV.Sprint7.Project.V12.Lib;
namespace Tyuiu.VegerinaVV.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_VVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogFirms_VVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        DataService ds = new DataService();
        string openFilePath;
        int rows;
        int columns;

        private void buttonAbout_VVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_VVV_Click(object sender, EventArgs e)
        {
            openFileDialog_VVV.ShowDialog();
            openFilePath = openFileDialog_VVV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_VVV.ColumnCount = columns = arrayValues.GetLength(1);
            dataGridViewData_VVV.RowCount = rows = arrayValues.GetLength(0);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewData_VVV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewData_VVV.Rows.Count != 0)
            {
                buttonRemove_VVV.Enabled = true;
            }
            buttonSave_VVV.Enabled = true;
        }

        private void buttonSave_VVV_Click(object sender, EventArgs e)
        {
            saveFileDialog_VVV.FileName = "DataBasePersonalComputer.csv";
            saveFileDialog_VVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_VVV.ShowDialog();


            string path = saveFileDialog_VVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_VVV.RowCount;
            int columns = dataGridViewData_VVV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewData_VVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewData_VVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAdd_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridViewData_VVV.Rows.Add();
                dataGridViewData_VVV.ClearSelection();
                dataGridViewData_VVV.Rows[rowIndex].Selected = true;
                dataGridViewData_VVV.FirstDisplayedScrollingRowIndex = rowIndex;
                dataGridViewData_VVV.CurrentCell = dataGridViewData_VVV.Rows[rowIndex].Cells[0];
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_VVV_Click(object sender, EventArgs e)
        {

            if (dataGridViewData_VVV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Строка не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные строки?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                DataGridViewRow[] rowsToRemove = new DataGridViewRow[dataGridViewData_VVV.SelectedRows.Count];
                dataGridViewData_VVV.SelectedRows.CopyTo(rowsToRemove, 0);

                foreach (DataGridViewRow r in rowsToRemove)
                {
                    dataGridViewData_VVV.Rows.Remove(r);
                }

                dataGridViewData_VVV.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления строки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataGridViewData_VVV.Rows.Count == 0)
            {
                buttonRemove_VVV.Enabled = false;
            }
        }

        private void buttonFilter_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dataGridViewData_VVV.Rows)
                {
                    if ((r.Cells[comboBoxName_VVV.SelectedIndex].Value?.ToString() ?? "").ToUpper().Contains(textBoxFilter_VVV.Text.ToUpper()))
                    {
                        dataGridViewData_VVV.Rows[r.Index].Visible = true;
                        dataGridViewData_VVV.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dataGridViewData_VVV.CurrentCell = null;
                        dataGridViewData_VVV.Rows[r.Index].Visible = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите столбец для фильтрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxName_VVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxName_VVV.SelectedIndex >= 0)
            {
                textBoxFilter_VVV.Enabled = true;
            }
            else
            {
                textBoxFilter_VVV.Enabled = false;
            }
        }

        private void textBoxSearch_VVV_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_VVV.Text.ToUpper();
            dataGridViewData_VVV.CurrentCell = null;
            foreach (DataGridViewRow r in dataGridViewData_VVV.Rows)
            {
                bool foundRow = false;

                for (int i = 0; i < r.Cells.Count; i++)
                {
                    DataGridViewCell cell = r.Cells[i];
                    string cellValue = (cell.Value?.ToString() ?? "").ToUpper();

                    if (!string.IsNullOrEmpty(searchText) && cellValue.Contains(searchText))
                    {
                        cell.Style.BackColor = Color.BlueViolet;
                        foundRow = true;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.Empty;
                    }
                }

                if (string.IsNullOrEmpty(searchText))
                {
                    r.Visible = true;
                }
                else
                {
                    r.Visible = foundRow;
                }
            }
        }

        private void buttonDownload_VVV_Click(object sender, EventArgs e)
        {
            openFileDialogFirms_VVV.ShowDialog();
            openFilePath = openFileDialogFirms_VVV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewFirms_VVV.ColumnCount = columns = arrayValues.GetLength(1);
            dataGridViewFirms_VVV.RowCount = rows = arrayValues.GetLength(0);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewFirms_VVV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewFirms_VVV.Rows.Count != 0)
            {
                buttonRemoveFirms_VVV.Enabled = true;
            }
            buttonSaveFirms_VVV.Enabled = true;
        }

        private void buttonChartMoney_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                chartMoney_VVV.Series[0].Points.Clear();
                chartMoney_VVV.Series[0].IsValueShownAsLabel = true;

                int money = dataGridViewFirms_VVV.ColumnCount - 1;

                int label = 1;

                if (money < 1)
                {
                    return;
                }

                foreach (DataGridViewRow r in dataGridViewFirms_VVV.Rows)
                {
                    string name = r.Cells[label].Value?.ToString() ?? "";

                    object value = r.Cells[money].Value;

                    double val = Convert.ToDouble(value);

                    chartMoney_VVV.Series[0].Points.AddXY(name, val);
                }
            }
            catch
            {
                MessageBox.Show("Невозможно построить диаграмму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartMoney_VVV_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoneStatistic_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < dataGridViewFirms_VVV.Rows.Count; i++)
                {
                    if (dataGridViewFirms_VVV.Rows[i].Visible)
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    int[] values = new int[count];
                    int index = 0;

                    for (int i = 0; i < dataGridViewFirms_VVV.Rows.Count; i++)
                    {
                        if (dataGridViewFirms_VVV.Rows[i].Visible)
                        {
                            string val = dataGridViewFirms_VVV.Rows[i].Cells[4].Value?.ToString() ?? "0";
                            values[index] = int.Parse(val);
                            index++;
                        }
                    }
                    textBoxMax_VVV.Text = ds.MaxValue(values).ToString();
                    textBoxMin_VVV.Text = ds.MinValue(values).ToString();
                    textBoxAverage_VVV.Text = ds.AverageValue(values).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка рассчета данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveFirms_VVV_Click(object sender, EventArgs e)
        {
            saveFileDialogFirms_VVV.FileName = "DataBaseFirms.csv";
            saveFileDialogFirms_VVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogFirms_VVV.ShowDialog();


            string path = saveFileDialogFirms_VVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewFirms_VVV.RowCount;
            int columns = dataGridViewFirms_VVV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewFirms_VVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewFirms_VVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAddFirms_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridViewFirms_VVV.Rows.Add();
                dataGridViewFirms_VVV.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                dataGridViewFirms_VVV.ClearSelection();
                dataGridViewFirms_VVV.Rows[rowIndex].Selected = true;
                dataGridViewFirms_VVV.FirstDisplayedScrollingRowIndex = rowIndex;
                dataGridViewFirms_VVV.CurrentCell = dataGridViewFirms_VVV.Rows[rowIndex].Cells[1];
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveFirms_VVV_Click(object sender, EventArgs e)
        {
            dataGridViewFirms_VVV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewFirms_VVV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Строка не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные строки?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                DataGridViewRow[] rowsToRemove = new DataGridViewRow[dataGridViewFirms_VVV.SelectedRows.Count];
                dataGridViewFirms_VVV.SelectedRows.CopyTo(rowsToRemove, 0);

                foreach (DataGridViewRow r in rowsToRemove)
                {
                    dataGridViewFirms_VVV.Rows.Remove(r);
                }

                dataGridViewFirms_VVV.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления строки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataGridViewFirms_VVV.Rows.Count == 0)
            {
                buttonRemoveFirms_VVV.Enabled = false;
            }
        }

        private void поддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupport formSupport = new FormSupport();
            formSupport.ShowDialog();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void buttonSumChart_VVV_Click(object sender, EventArgs e)
        {
            try
            {
                chartSum_VVV.Series[0].Points.Clear();
                chartSum_VVV.Series[0].IsValueShownAsLabel = true;
                int sumcolumn = dataGridViewData_VVV.ColumnCount - 1;

                double sumResult = 0;
                foreach (DataGridViewRow r in dataGridViewData_VVV.Rows)
                {
                    object cellValue = r.Cells[sumcolumn].Value;
                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double sum))
                    {
                        sumResult += sum;
                    }
                }
                chartSum_VVV.Series[0].Points.AddXY("", sumResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка построения диаграммы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
