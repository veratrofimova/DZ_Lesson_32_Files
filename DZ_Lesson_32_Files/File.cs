namespace DZ_Lesson_32_Files
{
    public class File
    {
        public List<string> CreateFile(string path)
        {            
            List<string> fullPaths = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                string fullPath = Path.Combine(path, $"File{i}.txt");
                System.IO.File.Create(fullPath).Dispose();

                fullPaths.Add(fullPath);
            }

            return fullPaths;
        }
    }
}
