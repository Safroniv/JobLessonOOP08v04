using JobLessonOOP08v04Part01.Interfaces;

namespace JobLessonOOP08v04Part01.Realises
{
    public class ElementFile : IFileOfFileSystem
    {

        public static List<FileInfo> GetFiles(string path)
        {
            if (path == null || path =="")
            {
                return null;
            }
            if (Path.HasExtension(path))
            {
                path = Path.GetDirectoryName(path);
            }
            return new DirectoryInfo(path).GetFiles().ToList();
        }
        public void CopyFile(string path, string newPath, string name)
        {
            throw new NotImplementedException();
        }

        public void CreateFile(string path, string name)
        {
            if (Directory.Exists(path))

            {
                if (name != "")
                { File.Create(path + name).Close(); }
                else
                {  Directory.GetDirectories(path);}
            }
        }

        public void DeleteFile(string path , string name)
        {
            throw new NotImplementedException();
        }

        public void GetFilesOfDir (string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                Console.WriteLine($"Содержимое категории (файлы) - {path}");
                foreach (string file in files)
                { Console.WriteLine(file); }
                Console.WriteLine($"-----------------------------------------");
            }
            else
                ExeptionInfo();
        }
        public void RenameFile(string path, string oldName, string newName)
        {
            throw new NotImplementedException();
        }
        public void TransferFile(string path, string oldName, string newName)
        {
            throw new NotImplementedException();
        }
        public void ExeptionInfo()
        {

        }
    }
}