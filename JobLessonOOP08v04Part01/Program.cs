
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




public class ObjectDirectory : IObjectFileSystem
{
    public void CopyObjectFileSystem(string path, string newPath)
    {
        throw new NotImplementedException();
    }

    public void CreateObjectFileSystem(string path)
    {
        throw new NotImplementedException();
    }

    public void DeleteObjectFileSystem(string path)
    {
        throw new NotImplementedException();
    }

    public void GetObjectFileSystem(string path)
    {
        throw new NotImplementedException();
    }

    public void RenameObjectFileSystem(string path, string newName)
    {
        throw new NotImplementedException();
    }

    public void TransferObjectFileSystem(string path, string newPath)
    {
        throw new NotImplementedException();
    }
}
public class ObjectFile : IObjectFileSystem
{
    public void CopyObjectFileSystem(string path, string newPath)
    {
        throw new NotImplementedException();
    }

    public void CreateObjectFileSystem(string path)
    {
        throw new NotImplementedException();
    }

    public void DeleteObjectFileSystem(string path)
    {
        throw new NotImplementedException();
    }

    public void GetObjectFileSystem(string path)
    {
        throw new NotImplementedException();
    }

    public void RenameObjectFileSystem(string path, string newName)
    {
        throw new NotImplementedException();
    }

    public void TransferObjectFileSystem(string path, string newPath)
    {
        throw new NotImplementedException();
    }
}
public interface IObjectFileSystem
{
    //Интерфейс требует реализации по CRUD (Create Read Update Delete),
    //но с учётом переноса и копирования:
    //Read Create Delete Rename Copy Transfer - RCDRCT
    public void GetObjectFileSystem (string path);
    public void CreateObjectFileSystem (string path);
    public void DeleteObjectFileSystem (string path);
    public void RenameObjectFileSystem (string path, string newName);
    public void CopyObjectFileSystem (string path, string newPath);
    public void TransferObjectFileSystem (string path, string newPath);
}

public class ObjectFileSystem
{
    public string? ObjectName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectPath { get; set; }
}