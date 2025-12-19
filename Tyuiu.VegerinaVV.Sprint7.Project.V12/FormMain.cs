using System.IO;
using Tyuiu.VegerinaVV.Sprint7.Project.V12.Lib;
namespace Tyuiu.VegerinaVV.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_VVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
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
            dataGridViewData_VVV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

                List<int> rowsToDelete = new List<int>();
                foreach (DataGridViewRow selectedRow in dataGridViewData_VVV.SelectedRows)
                    rowsToDelete.Add(selectedRow.Index);

                for (int i = rowsToDelete.Count - 1; i >= 0; i--)
                {
                    dataGridViewData_VVV.Rows.RemoveAt(rowsToDelete[i]);
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
    }
}
