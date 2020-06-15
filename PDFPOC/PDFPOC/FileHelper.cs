using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PDFPOC
{
    public class FileHelper
    {
        public static async Task<MemoryStream> DownloadFileAsStreamAsync(string url)
        {
            try
            {
                var stream = new MemoryStream();
                using (var httpClient = new HttpClient())
                {
                    var downloadStream = await httpClient.GetStreamAsync(new Uri(url));
                    if (downloadStream != null)
                    {
                        await downloadStream.CopyToAsync(stream);
                    }
                }

                return stream;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return null;
            }
        }

        public static async Task<bool> DownloadAndWriteIntoNewFile(string url, string fileName)
        {
            var stream = await DownloadFileAsStreamAsync(url);
            if (stream == null || stream.Length == 0)
                return false;

            var filePath = GetFilePath(fileName);

            DeleteSavedFile(filePath);
            CreateNewFile(filePath);
            OpenAndWriteIntoFile(stream, filePath);

            return true;
        }

        public static string GetFilePath(string fileName)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), fileName);
            return filePath;
        }

        public static void CreateNewFile(string filePath)
        {
            using (var createdFile = File.Create(filePath))
            {
            }
        }

        public static void OpenAndWriteIntoFile(MemoryStream stream, string filePath)
        {
            using (var openFile = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                stream.WriteTo(openFile);
            }
        }

        public static void DeleteSavedFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            File.Delete(filePath);
        }

        public static void WriteAsText(string filePath, string contents)
        {
            File.WriteAllText(filePath, contents);
        }

        public static string ReadAsText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }


    }
}
