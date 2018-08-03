using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
       public static int i = 0;
        public static string sourcePath1 = @"D:\Folder1\";
        public static string sourcePath2 = @"D:\Folder3\";
        public static string path1 = @"D:\Folder1\Write.txt";
        public static string path2 = @"D:\Folder2\Write.txt";
        public static Object thisLock1 = new Object();
        public static Object thisLock2 = new Object();
        public static Object thisLock3 = new Object();
        public static Object thisLock4 = new Object();
        public static Object thisLock5 = new Object();
        static void Main(string[] args)
        {
          
            ProccesFile();
             Run(); 
          
                Console.ReadKey();
        }
        public async static void ProccesFile() => await Task.Run(() =>
        {
            
            {
                while (true)
                { try
                    {
                        string[] Files1 = Directory.GetFiles(sourcePath1, "*", SearchOption.AllDirectories)
                           .Select(Path.GetFullPath)
                           .ToArray();
                        string[] Files2 = Directory.GetFiles(sourcePath2, "*", SearchOption.AllDirectories)
                        .Select(Path.GetFullPath)
                        .ToArray();
                        string[] Directory1 = Directory.GetDirectories(sourcePath1, "*", SearchOption.AllDirectories);
                        string[] Directory2 = Directory.GetDirectories(sourcePath2, "*", SearchOption.AllDirectories);
                        string[] Except1Copy = Files1.Select(x => x.Remove(0, sourcePath1.Count())).Except(Files2.Select(x => x.Remove(0, sourcePath2.Count()))).ToArray();
                        string[] Except2Copy = Directory1.Select(x => x.Replace(sourcePath1, sourcePath2)).Except(Directory2).ToArray();
                        string[] Except1subd = Files2.Select(x => x.Remove(0, sourcePath1.Count())).Except(Files1.Select(x => x.Remove(0, sourcePath2.Count()))).ToArray();
                        string[] Except2subd = Directory2.Except(Directory1.Select(x => x.Replace(sourcePath1, sourcePath2))).ToArray();
                        foreach (string dirPath in Except2Copy)
                            Directory.CreateDirectory(dirPath);
                        foreach (var item in Except1Copy)
                            File.Copy(sourcePath1 + item, sourcePath2 + item);
                        foreach (var item1 in Except1subd)
                            File.Delete(sourcePath2 + item1);
                        foreach (var item1 in Except2subd)
                            Directory.Delete(item1, true);
                        break;
                    }
                    catch { }
                }
            }
        });
      
        public async static void WriteFile() => await Task.Run(() =>
        {
           
                try
                {lock (thisLock1)
                {
                    string[] lines = { "First line", "Second", "Third line" };
                    using (StreamWriter outputFile = new StreamWriter(path1, true))
                    {
                        foreach (string line in lines)
                            outputFile.WriteLineAsync(line);
                        outputFile.Close();
                    }
                }
                }

                catch (Exception ex)
                {
                  
                }
            
        });
        public async static void ReadFile() => await Task.Run(() =>
        {
        string[] lines;
        var list = new List<string>();

            try
            {
                lock (thisLock2)
                {
                    var fileStream = new FileStream(path1, FileMode.Open, FileAccess.Read);
                    var streamReader = new StreamReader(fileStream, Encoding.UTF8, true);
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                    lines = list.ToArray();
                    foreach (var line1 in lines)
                        Console.WriteLine(line1);
                    streamReader.Close();
                }
            }
            catch (IOException ex) { }
                    
              
        });
        public static async void Run() => await Task.Run(() =>
        {
            string[] Directory1 = Directory.GetDirectories(sourcePath1, "*", SearchOption.AllDirectories);

            string[] Directory2 = Directory.GetDirectories(sourcePath2, "*", SearchOption.AllDirectories);
            List<string> list = new List<string>();
            list.Add(sourcePath1);
            list.Add(sourcePath2);
            foreach (string my_path in Directory1)
            {

                list.Add(my_path);
            }

            foreach (string my_path in Directory2)
            {

                list.Add(my_path);
            }
            foreach (string my_path in list)
            {

                Watch(my_path);
            }
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        });
        private static void Watch(string watch_folder)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = watch_folder;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
            | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }
        private async static void OnChanged(object source, FileSystemEventArgs e) => await Task.Run(() =>
        {        string sourcePath1 = @"D:\Folder1";
         string sourcePath2 = @"D:\Folder3";
        Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            if (e.FullPath != null)
            {
                string[] Directory1 = Directory.GetDirectories(sourcePath1, "*", SearchOption.AllDirectories);
                string[] Directory2 = Directory.GetDirectories(sourcePath2, "*", SearchOption.AllDirectories);
                List<string> list1 = new List<string>();
                List<string> list2 = new List<string>();
                list1.Add(sourcePath1);
                list2.Add(sourcePath2);
                foreach (string my_path in Directory1)
                {

                    list1.Add(my_path);
                }

                foreach (string my_path in Directory2)
                {

                    list2.Add(my_path);
                }
              
                        foreach (var item in list1)
                            if ((Path.GetDirectoryName(e.FullPath)) == item)
                            {
                                var file = File.OpenRead(e.FullPath);
                                string destDir = item.Replace(sourcePath1, sourcePath2);
                                FileInfo destFile = new FileInfo(Path.Combine(destDir, file.Name));
                                if (destFile.Exists)
                                { var s=MD5.Create();
                                    if (s.ComputeHash(file) > destFile.LastWriteTime)
                            {
                                while (true)
                                {
                                    try
                                    {
                                       file.CopyTo(destFile.FullName, true); break;

                                    }
                                    catch { }
                                }
                            }
                                }
                            }

                foreach (var item in list2)
                    if ((Path.GetDirectoryName(e.FullPath)) == item)
                    {
                        FileInfo file = new FileInfo(e.FullPath.Replace(sourcePath2, sourcePath1));
                        string destDir = item;
                        FileInfo destFile = new FileInfo(Path.Combine(destDir, Path.GetFileName(e.FullPath)));

                        if (destFile.Exists)
                        {
                            if (file.LastWriteTime < destFile.LastWriteTime)
                            {
                                while (true)
                                {
                                    try
                                    {
                                         file.CopyTo(destFile.FullName, true); break;
                                    }
                                    catch { }
                                }
                            }

                        }

                    }
            }
        });

    }

}

