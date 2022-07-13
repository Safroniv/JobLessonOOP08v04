namespace JobLessonOOP08v04Part01.Interfaces
{
    public interface IFileOfFileSystem
    {
        //Интерфейс требует реализации по CRUD (Create Read Update Delete),
        //но с учётом переноса и копирования:
        //Read Create Delete Rename Copy Transfer - RCDRCT
        public void GetFilesOfDir(string path);
        public void CreateFile(string path, string name);
        public void DeleteFile(string path, string name);
        public void RenameFile(string path, string newPath);
        public void CopyFile(string path, string newPath);
        public void TransferFile(string path, string newPath);
    }
}