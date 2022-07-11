
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

Console.WriteLine("Тестовый вывод категории");
ElementDirectoryOfFileSystem elementDirectoryOfFileSystem = new ElementDirectoryOfFileSystem();
elementDirectoryOfFileSystem.Path = $@"C:\";
ElementDirectory ElementDirectory = new ElementDirectory();
ElementDirectory.GetElement(elementDirectoryOfFileSystem.Path);


/// <summary>
/// Класс определяет действия над директорией
/// </summary>
public class ElementDirectory : IElementOfFileSystem
{    
    ElementDirectoryOfFileSystem directoryOfFileSystem = new ElementDirectoryOfFileSystem();
    
    
    public void GetElement(string path)
    {
        directoryOfFileSystem.Path = $@"C:\";
        path = directoryOfFileSystem.Path;
        if(Directory.Exists(path))
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (string stringPath in dirs)
            { Console.WriteLine(stringPath);}
        }
    }
    public void CopyElement(string path, string newPath)
    {
        throw new NotImplementedException();
    }

    public void CreateElement(string path)
    {
        throw new NotImplementedException();
    }

    public void DeleteElement(string path)
    {
        throw new NotImplementedException();
    }
    public void RenameElement(string path, string newName)
    {
        throw new NotImplementedException();
    }

    public void TransferElement(string path, string newPath)
    {
        throw new NotImplementedException();
    }
}
public class ElementFile
{
    
}

public interface IElementOfFileSystem
{
    //Интерфейс требует реализации по CRUD (Create Read Update Delete),
    //но с учётом переноса и копирования:
    //Read Create Delete Rename Copy Transfer - RCDRCT
    public void GetElement (string path);
    public void CreateElement (string path);
    public void DeleteElement (string path);
    public void RenameElement (string path, string newName);
    public void CopyElement (string path, string newPath);
    public void TransferElement (string path, string newPath);
}

public abstract class BaseElementOfFileSystem
{
    public string? Name { get; set; }
    public string? Path { get; set; }
    public DateTime? CreateDate { get; set; }
    public abstract TypeElementOfFileSystem Type { get;}
}

public class ElementFileOfFileSystem : BaseElementOfFileSystem
{
    public override TypeElementOfFileSystem Type => TypeElementOfFileSystem.ElementFile;
}
public class ElementDirectoryOfFileSystem : BaseElementOfFileSystem
{
    public override TypeElementOfFileSystem Type => TypeElementOfFileSystem.ElementDirectory;
}

public enum TypeElementOfFileSystem
{
    ElementFile,
    ElementDirectory,
}