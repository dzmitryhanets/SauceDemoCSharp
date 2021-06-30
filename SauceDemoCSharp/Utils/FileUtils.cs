using System.IO;

namespace SauceDemoCSharp.Utils
{
    public static class FileUtils
    {
        public static string ReadAllText(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            throw new FileNotFoundException($"File path doesn't exist: {path}");
        }
    }
}
