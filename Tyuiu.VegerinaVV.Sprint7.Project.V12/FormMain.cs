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
    }
}
