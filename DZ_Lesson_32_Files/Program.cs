using DZ_Lesson_32_Files;
using DirectoryInfo = DZ_Lesson_32_Files.DirectoryInfo;
using File = DZ_Lesson_32_Files.File;

Console.WriteLine("Начинаем изучать работы с файлами!\r\n");

try
{
    var directoryInfo = new DirectoryInfo();
    var directories = directoryInfo.CreateDirectory();

    var file = new File();
    var paths = new List<string>();
    directories.ForEach(x => paths.AddRange(file.CreateFile(x)));

    var fileOpertion = new FileOpertion();
    fileOpertion.AddText(paths);

    List<Task> tasks = paths.Select(async path => await fileOpertion.AddDataAsync(path)).ToList();
    await Task.WhenAll(tasks);

    fileOpertion.WaitForResult(paths);
}
catch (Exception)
{
    throw;
}