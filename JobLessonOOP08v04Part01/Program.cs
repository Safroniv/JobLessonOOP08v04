
//Основы ООП в С#
//Урок 8. Итоговый проект
//1. Реализовать простейший файловый менеджер с использованием ООП
//(классы, наследование и прочее).
//### Файловый менеджер должен иметь возможность:
//*показывать содержимое дисков;
//*создавать папки / файлы;
//*удалять папки / файлы;
//*переименовывать папки / файлы;
//*копировать / переносить папки / файлы;
//*вычислять размер папки/файла;
//*производить поиск по маске (с поиском по подпапкам);
//*для текстовых файлов готовить статические данные 
//(кол-во слов,
// кол-во строк,
// кол-во абзацев,
// кол-во символов с пробелами,
// кол-во слов без пробелов).    
//Предусмотреть возможность изменения атрибутов файлов.  

Console.WriteLine("Hello, World!");




public class ObjectDirectory
{

}
public class ObjectFile 
{

}

public interface IFileOfFileSystem
{
    //Интерфейс требует реализации по CRUD (Create Read Update Delete),
    //но с учётом переноса и копирования:
    //Read Create Delete Rename Copy Transfer - RCDRCT
    public void GetFile(string path);
    public void CreateFile(string path);
    public void DeleteFile(string path);
    public void RenameFile(string path, string newName);
    public void CopyFile(string path, string newPath);
    public void TransferFile(string path, string newPath);
}
public interface IDirectoryOfFileSystem
{
    //Интерфейс требует реализации по CRUD (Create Read Update Delete),
    //но с учётом переноса и копирования:
    //Read Create Delete Rename Copy Transfer - RCDRCT
    public void GetDirectiry (string path);
    public void CreateDirectiry(string path);
    public void DeleteDirectiry(string path);
    public void RenameDirectiry(string path, string newName);
    public void CopyDirectiry(string path, string newPath);
    public void TransferDirectiry(string path, string newPath);
}

public class BaseElementOfFileSystem
{
    public string? Name { get; set; }
    public string? Path { get; set; }
    public DateTime? CreateDate { get; set; }
}

public class ElementFileOfFileSystem : BaseElementOfFileSystem
{

}
public class ElementDirectoryOfFileSystem : BaseElementOfFileSystem
{

}