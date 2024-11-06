namespace DZ_Lesson_32_Files
{
    public class DirectoryInfo
    {
        public List<string> CreateDirectory()
        {
            List<string> paths = new List<string> { "c:\\Otus\\TestDir1", "c:\\Otus\\TestDir2" };
            foreach (string path in paths)
            {
                Directory.CreateDirectory(path);
            }

            return paths;
        }
    }
}
