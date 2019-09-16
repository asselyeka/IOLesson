using System;
using System.IO;
using System.Text;

namespace IOLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var fullFilePath = string.Empty;

            Console.WriteLine("Hello! Please choose number of drive.");
            var drives = DriveInfo.GetDrives();

            for(int i = 0; i<drives.Length; i++)
            {
                if(drives[i].IsReady)
                Console.WriteLine($"{i+1}.{drives[i].Name} - {drives[i].TotalFreeSpace} байт свободно");
            }

            if (int.TryParse(Console.ReadLine(), out int userDrivePosition))
            {
                int index = userDrivePosition - 1;
                var rootDirectory = drives[index].RootDirectory;
                fullFilePath = rootDirectory.FullName;

                Console.WriteLine("Введите имя новой директорий для файла:");
                var newDirectory = Console.ReadLine();

                fullFilePath += newDirectory + "\\";
                var directoryForFile = Directory.CreateDirectory(fullFilePath);

                Console.WriteLine("Введите имя текстового файла для создания:");
                var newFile = Console.ReadLine();
                fullFilePath += newFile + ".txt";
                File.Create(fullFilePath).Close();

                Console.WriteLine("Введите текст:");
                File.WriteAllText(fullFilePath, Console.ReadLine());

                
             Stream - базовый тип для потоков. Он disposable.
             Основной поток для работы с байтами - FileStream
             Основной поток для работы с текстами - StreamReader, StreamWriter
             их еще много, суть работы одна


            1. Открыть поток
            2. Получить откуда-то данные для записи(текст, байты и т д)
            3. Записать данные в поток
            4. Закрыть поток (не надо, если using)
             

                Directory.CreateDirectory(@"C:\Новая папка");
                using (var stream = new FileStream(@"C:\Новая папка\1.txt", FileMode.OpenOrCreate))
                {
                    var text = "Какой-то текст";
                    var bytes = Encoding.Default.GetBytes(text);

                    stream.Write(bytes, 0, bytes.Length);
                }


                using (var stream = new FileStream(@"Z:\Homework_13\1.txt", FileMode.Open))
                {
                    var bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, bytes.Length);
                    var text = Encoding.Default.GetString(bytes);
                }
            }
        */

            using (var stream = new FileStream(@"Z:\Homework_13\1.txt", FileMode.Open))
            {
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                var text = Encoding.Default.GetString(bytes);


                foreach(var symbol in text)
                {
                    if(symbol )
                }
            }



            /*

            using (var stream = new StreamWriter(@"C:\Новая папка\1.txt"))
            {
                var text = "Какой-то текст";
                stream.Write(text);
            }


            using (var stream = new StreamReader(@"C:\Новая папка\1.txt"))
            {
                var text = stream.ReadToEnd();
            }

            using (var stream = File.OpenRead(@"C:\Новая папка\1.txt"))
            {
                var text = stream.ReadToEnd();
            }

            var result = Encoding.Default.GetString(File.ReadAllBytes(@"C:\Новая папка\1.txt"));
            var resultOptimal = File.ReadAllText(@"C:\Новая папка\1.txt");
            */
        }
    }
}
