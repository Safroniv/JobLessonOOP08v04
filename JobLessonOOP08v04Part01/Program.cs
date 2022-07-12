
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

using JobLessonOOP08v04Part01.ElementsFileSystem;
using JobLessonOOP08v04Part01.Realises;

ElementDirectory elementDirectory = new ElementDirectory();
ElementFile elementFile = new ElementFile();
string path = @"D:\\";
string name = null;

while (true)
{
    Console.WriteLine($"-----------------------------------------");
    elementDirectory.GetDir(path);
    elementFile.GetFilesOfDir(path);
    elementDirectory.GetDiscs();
    Console.WriteLine("Укажите категорию");
    path = Console.ReadLine();
    Console.WriteLine("Укажите имя");
    name = Console.ReadLine();
    elementDirectory.CreateDir(path, name);
    Console.Clear();
}
