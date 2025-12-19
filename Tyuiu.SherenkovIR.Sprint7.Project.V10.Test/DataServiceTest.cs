using Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint7.Project.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string pathsave = Path.Combine("C:", "DataSprint7", "TEST.csv");
            using (StreamWriter writer = new StreamWriter(pathsave))
            {
                writer.WriteLine("1;8");
                writer.WriteLine("0;5");
                writer.WriteLine("4;9");
            }
            string[,] res = ds.GetMatrix(pathsave);
            string[,] wait = { { "1", "8" }, { "0", "5" }, { "4", "9" } };
            CollectionAssert.AreEqual(res, wait);
        }

    }
    
}
