using JobLessonOOP08v04Part01.Interfaces;

namespace JobLessonOOP08v04Part01.RealiseInterfaces
{
    /// <summary>
    /// Класс определяет действия над директорией
    /// </summary>
    public class ElementDirectory : IDirectoryOfFileSystem
    {
        //Попробовать обернуть всё вместе в try catch
        public static List<DirectoryInfo>? Dirs(string path)
        {
            if (path == null || path == "")
                return null;
            if (Path.HasExtension(path))
                path = Path.GetDirectoryName(path);
            return new DirectoryInfo(path).GetDirectories().ToList();
        }
        public static List<DriveInfo> GetDiscDates()
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            List<DriveInfo> list = new();
            foreach (DriveInfo driveInfo in driveInfos)
                if (driveInfo.IsReady) list.Add(driveInfo);
            return list;
        }
        public void GetLogicDiscs()
        {
            Console.WriteLine($"Логические диски ОС:");
            foreach (var file in ElementDirectory.GetDiscDates())
                Console.WriteLine(file);
        }
        public void GetDir(string path)
        {
            if (Directory.Exists(path))
            {
                string[] dirs = Directory.GetDirectories(path);
                Console.WriteLine($"Содержимое категории - {path}");
                foreach (string dirPath in dirs)
                    Console.WriteLine(dirPath);
                Console.WriteLine($"-----------------------------------------");
            }
            else
                ExeptionInfo();
        }
        public void CopyDir(string path, string newPath)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo directoryFrom = new (path);
                DirectoryInfo directoryTo = new (newPath);
                if (Directory.Exists(directoryTo.FullName) == false)
                {
                    Directory.CreateDirectory(directoryTo.FullName);
                }
                foreach (FileInfo fileInfo in directoryFrom.GetFiles())
                    fileInfo.CopyTo(Path.Combine(directoryTo.FullName, fileInfo.Name), true);
                foreach (DirectoryInfo directoryToSubs in directoryFrom.GetDirectories())
                    directoryTo.CreateSubdirectory(directoryToSubs.Name);
            }
        }

        public void CreateDir(string path, string name)
        {
            if (Directory.Exists(path))
                if (name != "")
                    Directory.CreateDirectory($@"{path}\{name}");
                else
                {
                    if (Directory.Exists(path))
                        Directory.GetDirectories(path);
                    else
                        ExeptionInfo();
                }
        }

        public void DeleteDir(string path, string name)
        {
            try
            {
                path = Path.Combine(path, name);
                DirectoryInfo directoryInfo = new(path);
                directoryInfo.Delete();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }
        public void RenameDir(string path, string newPath)
        {
            Directory.Move(path, newPath);
        }

        public void TransferDir(string path, string newPath)
        {
            DirectoryInfo directoryInfo = new (path);
            if (directoryInfo.Exists && Directory.Exists(newPath) == false)
            {
                directoryInfo.MoveTo(newPath);
            }
        }
        public void SearchDirFromMask(string path, string name)
        {
            string[] dirs = Directory.GetDirectories(path, name);
            Console.WriteLine($"Всего директорий по запросу '{name}' найдено {dirs.Length}");

            foreach (string dir in dirs)
                Console.WriteLine(dir);
        }
        public void SizeDir(string path)
        {
            DirectoryInfo dirInfo = new (path);
            Console.WriteLine($"Название директории: {dirInfo.Name}");
            Console.WriteLine($"Порный путь к директории: {dirInfo.FullName}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
        }

        public void ExeptionInfo()
        {
            Console.WriteLine("Неверный адрес директории!");
            Console.WriteLine("Введите адрес директории: ");
        }
    }
}