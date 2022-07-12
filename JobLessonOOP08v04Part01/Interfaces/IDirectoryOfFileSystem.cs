namespace JobLessonOOP08v04Part01.Interfaces
{
    public interface IDirectoryOfFileSystem
    {
        //Интерфейс требует реализации по CRUD (Create Read Update Delete),
        //но с учётом переноса и копирования:
        //Read Create Delete Rename Copy Transfer - RCDRCT

        public void GetDir(string path);
        public void CreateDir(string path, string name);
        public void DeleteDir(string path, string name);
        public void RenameDir(string path, string oldName, string newName);
        public void CopyDir(string path, string newPath, string name);
        public void TransferDir(string path, string newPath, string name);
    }
}