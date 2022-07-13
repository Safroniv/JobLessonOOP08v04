using JobLessonOOP08v04Part01.RealiseInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLessonOOP08v04Part01.CaseCommands
{
	public class CaseCommands
	{

		public void Case()
		{

			while (true)
			{
				Console.WriteLine($"-----------------------------------------");
				Console.WriteLine("Укажите команду или введите info, для получения списка команд");
				string command = Console.ReadLine();
				Console.Clear();
				CaseCommands(command);
			}
			static void CaseCommands(string command)
			{
				ElementDirectory elementDirectory = new();
				ElementFile elementFile = new();
				string path = @"C:\\";
				//подумать над альтернативным именем - nameOrNewPath
				string nameOrNewPath = null;
				switch (command)
				{
					case "info":
						//"info - показать список команд для работы с менеджером",
						foreach (var infoList in CommandsInfo.Commandsaf)
							Console.WriteLine(infoList);
						break;

					case "disc":
						//"disc - отобразить на консоль список логических дисков",						
						elementDirectory.GetLogicDiscs();
						break;

					case "view":
						//"view - отобразить на консоль содержимого категории",		
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						elementDirectory.GetDir(path);
						elementFile.GetFilesOfDir(path);
						break;

					case "newd":
						//"newd - создать новую категорию",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						Console.WriteLine("Укажите название новой директории");
						nameOrNewPath = Console.ReadLine();
						elementDirectory.CreateDir(path, nameOrNewPath);
						break;

					case "newf":
						//"newf - создать новый файл",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						Console.WriteLine("Укажите название нового файла с расширением. Формат ввода: text.txt");
						nameOrNewPath = Console.ReadLine();
						elementFile.CreateFile(path, nameOrNewPath);
						break;

					case "rend":
						//"rend - переименова директорию",
						UserRequests();
						elementDirectory.RenameDir(path, nameOrNewPath);
						break;

					case "renf":
						//"renf - переименовать файл",
						UserRequests();
						elementFile.RenameFile(path, nameOrNewPath);
						break;

					case "movd":
						//"movd - переместить директорию",
						UserRequests();
						elementDirectory.TransferDir(path, nameOrNewPath);
						break;

					case "movf":
						//"movf - переместить файл",
						UserRequests();
						elementFile.TransferFile(path, nameOrNewPath);
						break;

					case "copd":
						//"copd - скопировать директорию",
						UserRequests();
						elementDirectory.CopyDir(path, nameOrNewPath);
						break;

					case "copf":
						//"copf - скопировать файл",
						UserRequests();
						elementFile.CopyFile(path, nameOrNewPath);
						break;

					case "deld":
						//"deld - удалить директорию",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						Console.WriteLine("Укажите название директории для удаления. Формат ввода: (d:\\folder\\folder)");
						nameOrNewPath = Console.ReadLine();
						elementDirectory.DeleteDir(path, nameOrNewPath);
						break;

					case "delf":
						//"delf - удалить файл",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						Console.WriteLine("Укажите название файла для удаления. Формат ввода: text.txt");
						nameOrNewPath = Console.ReadLine();
						elementFile.DeleteFile(path, nameOrNewPath);
						break;

					case "fndd":
						//"fndd - выполнить поиск директорий по маске",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						Console.WriteLine("Укажите название директории для поиска. Формат ввода: fol*");
						nameOrNewPath = Console.ReadLine();
						elementDirectory.SearchDirFromMask(path, nameOrNewPath);
						break;

					case "fndf":
						//"fndf - выполнить поиск файлов по маске",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						Console.WriteLine("Укажите название директории для поиска. Формат ввода: *.txt");
						nameOrNewPath = Console.ReadLine();
						elementFile.SearchFilesFromMask(path, nameOrNewPath);
						break;

					case "sizd":
						//"sizd - вычислить размер директории",
						Console.WriteLine("Укажите адрес директории. Формат ввода: (d:\\folder\\folder)");
						path = Console.ReadLine();
						elementDirectory.SizeDir(path);
					break;

					case "sizf":
						//"sizf - вычислить размер файла",
						Console.WriteLine("Укажите адрес файла. Формат ввода: (d:\\folder\\folder\\text.txt)");
						path = Console.ReadLine();
						elementFile.SizeFile(path);
						break;

					case "inff":
						//"inff - отборазить на консоль статистическое данные текстовых файлов",
						Console.WriteLine("Укажите адрес файла. Формат ввода: (d:\\folder\\folder\\text.txt)");
						path = Console.ReadLine();
						elementFile.InfoTextFile(path);
						break;

					case "atrf":
						//"atrf - изменить атрибуты файла",
						Console.WriteLine("Укажите адрес файла. Формат ввода: (d:\\folder\\folder\\text.txt)");
						path = Console.ReadLine();
						Console.WriteLine(@"Передайте параметр  для файла 'f'- снятие ограничения только для чтения, 't'- только для чтения");
						nameOrNewPath = Console.ReadLine();
						elementFile.AttributeFile(path, nameOrNewPath);
						break;

					case "exit":
						//"exit - выйти из программы",
						Environment.Exit(0);
						break;

					default:
						break;
				}
				void UserRequests()
				{
					Console.WriteLine("Укажите адрес. Формат ввода: (d:\\folder\\folder\\oldname)");
					path = Console.ReadLine();
					Console.WriteLine("Укажите новое имя (путь). Формат ввода: (d:\\folder\\folder\\newname)");
					nameOrNewPath = Console.ReadLine();
				}
			}
		}
	}
}
