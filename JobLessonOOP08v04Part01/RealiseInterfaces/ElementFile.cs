using JobLessonOOP08v04Part01.Interfaces;

namespace JobLessonOOP08v04Part01.RealiseInterfaces
{
    public class ElementFile : IFileOfFileSystem
    {
        //Попробовать обернуть всё вместе в try catch
        public static List<FileInfo>? GetFiles(string path)
        {
            if (path == null || path == "")
                return null;
            if (Path.HasExtension(path))
                path = Path.GetDirectoryName(path);
            return new DirectoryInfo(path).GetFiles().ToList();
        }
        public void CopyFile(string path, string newPath)
        {
            File.Copy(path, newPath, true);
        }

        public void CreateFile(string path, string name)
        {
            if (Directory.Exists(path))
            {
                if (name != "") File.Create(path + name);
                else
                {
                    if (Directory.Exists(path))
                        Directory.GetDirectories(path);
                    else
                        ExeptionInfo();
                }
            }
        }

        public void DeleteFile(string path, string name)
        {
            path = Path.Combine(path, name);
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
                fileInfo.Delete();
        }

        public void GetFilesOfDir(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                Console.WriteLine($"Содержимое категории (файлы) - {path}");
                foreach (string file in files)
                    Console.WriteLine(file);
                Console.WriteLine($"-----------------------------------------");
            }
            else { ExeptionInfo(); }

        }
        public void RenameFile(string path, string newPath)
        {
            File.Move(path, newPath);
        }
        public void TransferFile(string path, string newPath)
        {
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
                fileInfo.MoveTo(newPath);
        }
        public void SearchFilesFromMask(string path, string name)
        {
            string[] files = Directory.GetFiles(path, name);
            Console.WriteLine($"Всего директорий по запросу '{name}' найдено {files.Length}");

            foreach (string file in files)
                Console.WriteLine(file);
        }
        public void SizeFile(string path)
        {
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
                Console.WriteLine($"Имя файла: {fileInfo.Name}, размер файла: {fileInfo.Length}");
        }
        public void InfoTextFile(string path)
        {
            try
            {
                using (StreamReader streamReader = new(path))
                {
                    Console.WriteLine(streamReader.ReadToEnd());     //весь текст
                    string word = "";
                    string[] words;

                    while (streamReader.EndOfStream != true)
                    {
                        word += streamReader.ReadLine();
                    }
                    words = word.Split(' ');
                    Console.WriteLine("Количество слов: " + words.Length);
                }

                using (StreamReader streamReader = new(path))
                {
                    string line;
                    int i = 0;
                    while ((line = streamReader.ReadLine()) != null)

                    {
                        i++;
                        //Console.WriteLine(line);
                    }
                    Console.WriteLine("Количество строк: " + i.ToString());
                }

                using (StreamReader streamReader = new(path))
                {
                    string line;
                    int i = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line[0] == '\t')
                        {
                            i++;
                        }
                    }
                    Console.WriteLine("Количество абзацев: " + i.ToString());
                }

                using (StreamReader streamReader = new(path))
                {
                    string symbolsString = streamReader.ReadToEnd();
                    char[] symbolString = symbolsString.ToCharArray();

                    Console.WriteLine("Количество символов с пробелами: " + symbolString.Length.ToString());
                }

                using (StreamReader streamReader = new(path))
                {
                    string st = streamReader.ReadToEnd();
                    string[] SMass;
                    int sumStr = 0;

                    SMass = st.Split(' ', '\n');

                    foreach (var i in SMass)
                    {
                        if (i == "" || i == "\r")
                        {
                            continue;
                        }
                        sumStr++;
                    }
                    Console.WriteLine("Количество слов без пробелов: " + sumStr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AttributeFile(string path, string name)
        {
            FileInfo fileInfo = new(path);

            bool at = false;
            if (name == "t")
            {
                at = true;
            }

            fileInfo.IsReadOnly = at;

            Console.WriteLine("Атрибут только для чтения: " + fileInfo.IsReadOnly);
        }

        public void ExeptionInfo()
        {
            Console.WriteLine("Неверный адрес файла директории!");
            Console.WriteLine("Введите адрес директории искомого файла: ");

        }
    }
}
