using System.IO;
using System.Text;

namespace WinFormsApp1
{
    internal static class Parameters
    {
        public static string[] ParametersLoad()
        {
            string[] line = new string[2];
            using (StreamReader reader = new StreamReader(@"param.txt"))
            {
                string? readLine;
                line[0] = reader.ReadLine();
                line[1] = reader.ReadLine();
            }
            return line;
        }
        public static void ParametersSave(string _path, string _regex)
        {
            using (StreamWriter writer = new StreamWriter(@"param.txt", true))
            {
                writer.WriteLine(_path);
                writer.WriteLine(_regex);
            }
        }
    }
}
