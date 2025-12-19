namespace Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден : {path}");
            }
            string file_raw = File.ReadAllText(path);
            string[] lines = file_raw.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] result = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] element = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = element[j];
                }
            }
            return result;
        }
    }
}
