using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using PlayerConceptDesign.Settings;

namespace PlayerConceptDesign.ViewModel
{
    public static class Files
    {
        public static string[] FilesFormats = new string[] { ".mp3" }; // Можно добавить и другие 
        public static string FileLink { get; private set; }
        public static List<BitmapImage> Covers { get; private set; }

        static Files()
        {
            FileLink = GetFileLink();
            Covers = GetCoverFile(SettingsManager.AppSettings.Files);
        }

        public static bool CheckFileFormat(string fileLink)
        {
            for (int i = 0; i < FilesFormats.Length; i++)
                if (fileLink.Substring(fileLink.Length - FilesFormats[i].Length, FilesFormats[i].Length) != FilesFormats[i])
                    return false;
            return true;
        }
        
        public static string Trim(string folder, string to)
        {
            while (folder.Substring(folder.Length - 1) != to)
            {
                if (folder.Length <= 1) return "";
                folder = folder.Substring(0, folder.Length - 1);
            }
            return folder.Substring(0, folder.Length - 1);
        }

        public static string TrimBack(string folder, string to)
        {
            while (folder.Substring(0,1) != to)
            {
                if (folder.Length <= 1) return "";
                folder = folder.Substring(1, folder.Length - 1);
            }
            return folder.Substring(2, folder.Length - 2);
        }

        public static void SetDataFilesAppSettings(string path)
        {
            if (path == null)
                return;

            SettingsManager.AppSettings.Files = FindFilesFormats(Directory.GetFiles(SettingsManager.AppSettings.Folder = path));
            SettingsManager.AppSettings.Name = GetNameFile(SettingsManager.AppSettings.Files);
            SettingsManager.AppSettings.Save();
        }

        public static string GetFileLink() => Environment.GetCommandLineArgs()[Environment.GetCommandLineArgs().Length-1];

        public static List<string> FindFilesFormats(string[] Files)
        {
            List<string> FoundFiles = new List<string>();
            for (int i = 0; i < Files.Length; i++)
                for (int j = 0; j < FilesFormats.Length; j++)
                    if (CheckFileFormat(Files[i]))
                        FoundFiles.Add(Files[i]);
            return FoundFiles;
        }

        public static List<string> GetNameFile(List<string> Files)
        {
            List<string> FileNames = new List<string>();
            for (int i = 0; i < Files.Count; i++)
                FileNames.Add(Trim(Path.GetFileName(Files[i]), "."));
            return FileNames;
        }

        public static string GetNameFile(string File) => Trim(Path.GetFileName(File), ".");

        public static List<BitmapImage> GetCoverFile(List<string> Files)
        {
            List<BitmapImage> FileCovers = new List<BitmapImage>();
            Random random = new Random();
            for (int i = 0; i < Files.Count; i++)
            {

                if (TagLib.File.Create(Files[i]).Tag.Pictures.Length > 0)
                    FileCovers.Add(Cover.GetCoverFile(TagLib.File.Create(Files[i])));
                else
                {
                    BitmapImage BitmapImage_ = new BitmapImage();
                    BitmapImage_.BeginInit();
                    BitmapImage_.UriSource = new Uri("pack://application:,,,/Resources/Cover/" + random.Next(6).ToString() + "cover.png");
                    BitmapImage_.EndInit();
                    FileCovers.Add(BitmapImage_);
                }
            }
            return FileCovers;
        }
        public static BitmapImage GetCoverFile(string File)
        {
            BitmapImage FileCover;
            if (TagLib.File.Create(File).Tag.Pictures.Length > 0)
                FileCover = Cover.GetCoverFile(TagLib.File.Create(File));
            else
            {
                Random random = new Random();
                BitmapImage BitmapImage_ = new BitmapImage();
                BitmapImage_.BeginInit();
                BitmapImage_.UriSource = new Uri("pack://application:,,,/Resources/Cover/" + random.Next(6).ToString() + "cover.png");
                BitmapImage_.EndInit();
                FileCover = BitmapImage_;
            }
            return FileCover;
        }
    }
}
