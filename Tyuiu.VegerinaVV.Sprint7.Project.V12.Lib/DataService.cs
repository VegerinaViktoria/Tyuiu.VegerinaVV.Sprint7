using System.IO;
namespace Tyuiu.VegerinaVV.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows;
            int columns;
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] mtrx = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = Convert.ToString(line_r[j]);
                }
            }
            return mtrx;
        }
        public double MinValue(int[] values)
        {
            double min = values.Min();
            return min;
        }
        public double MaxValue(int[] values)
        {
            double max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }
        public double AverageValue(int[] values)
        {
            double average = 0;

            double sumAverage = 0;


            for (int i = 0; i < values.Length; i++)
            {
                sumAverage += values[i];
            }
            average = (sumAverage / values.Length);

            return Math.Round(average, 2);
        }

    }
}
