Console.WriteLine("Hello, World!");




public class ObjectDirectory : IObjectFileSystem
{

}
public class ObjectFile : IObjectFileSystem
{

}
public interface IObjectFileSystem
{
    //Требует реализации по CRUD (Create Read Update Delete)
    //но с учётом переноса и копирования:
    //Read Create Delete Rename Copy Transfer - RCDRCT

}

public class ObjectFileSystem
{
    public string ObjectName { get; set; }
    public string ObjectPath { get; set; }
}