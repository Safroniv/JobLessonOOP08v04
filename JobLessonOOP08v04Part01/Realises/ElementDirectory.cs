using JobLessonOOP08v04Part01.Interfaces;

namespace JobLessonOOP08v04Part01.Realises
{
    /// <summary>
    /// Класс определяет действия над директорией
    /// </summary>
    public class ElementDirectory : IDirectoryOfFileSystem
    {
        public static List <DirectoryInfo> Dirs (string path)
        {
            if (path == null || path == "")
            {
                return null;
            }
            if (Path.HasExtension(path))
            {
                path = Path.GetDirectoryName(path);
            }
            return new DirectoryInfo(path).GetDirectories().ToList();
        }
        public static List <DriveInfo> GetDiscDates()
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            List <DriveInfo> list = new List <DriveInfo>();
            foreach (DriveInfo driveInfo in driveInfos)
            {
                if (driveInfo.IsReady)
                    list.Add (driveInfo);
                
            }
            return list;
        }
        public void GetDiscs ()
        {
            Console.WriteLine($"Логические диски ОС:");
            foreach (var file in ElementDirectory.GetDiscDates())
            {
                Console.WriteLine(file);
            }
        }

        public void GetDir(string path)
        {
            if (Directory.Exists(path))
            {
                string[] dirs = Directory.GetDirectories(path);
                Console.WriteLine($"Содержимое категории - {path}");
                
                foreach (string dirPath in dirs)
                { Console.WriteLine(dirPath); }
                Console.WriteLine($"-----------------------------------------");


            }
            else
                ExeptionInfo();
        }
        public void CopyDir(string path, string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public void CreateDir(string path, string name)
        {
            if (name != "")
            { Directory.CreateDirectory(@$"{path}\{name}"); }
            else
            {
                if (Directory.Exists(path))
                { Directory.GetDirectories(path); }
                else
                    ExeptionInfo();
            }
        }

        public void DeleteDir(string path, string name)
        {
            throw new NotImplementedException();
        }
        public void RenameDir(string path, string newName, string name)
        {
            throw new NotImplementedException();
        }

        public void TransferDir(string path, string newPath, string name)
        {
            throw new NotImplementedException();
        }
        public void ExeptionInfo()
        {
            Console.WriteLine("Неверный адрес директории!");
            Console.WriteLine("Введите адрес директории: ");
        }
    }
}