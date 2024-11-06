using System.Text;

namespace DZ_Lesson_32_Files
{
    public class FileOpertion
    {
        public void AddText(List<string> paths)
        {

            foreach (string path in paths)
            {
                try
                {
                    string fileName = Path.GetFileName(path);

                    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(fileName);
                        fs.Write(data, 0, data.Length);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Файл не существует: {path}");
                }
            }
        }

        public async Task AddDataAsync(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    await writer.WriteAsync($" {DateTime.Now.ToString()}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Файл не существует: {path}");
            }
        }

        public void WaitForResult(List<string> paths)
        {
            foreach (var path in paths)
            {
                try
                {
                    string fileName = Path.GetFileName(path);
                    var text = System.IO.File.ReadAllText(path);

                    Console.WriteLine($"{fileName}: {text}");
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Файл не существует: {path}");
                }
            }
        }
    }
}
