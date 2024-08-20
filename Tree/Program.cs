
namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = @"c:\users";
            PrintDirectory(folder);
        }

        private static void PrintDirectory(string folder,int level=0)
        {

            try
            {
                foreach (string path in Directory.GetDirectories(folder))
                {
                    Console.WriteLine(new string('\t', level) + path);
                    PrintDirectory(path,level++);
                }
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
