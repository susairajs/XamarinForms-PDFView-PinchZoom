using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PDFPOC.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace PDFPOC.Droid
{
    public class FileHelper : IFile
    {
        private readonly string _rootDir = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "pdfjs");

        public async Task<string> SaveFile(Stream stream, string fileName)
        {
            if (!Directory.Exists(_rootDir))
                Directory.CreateDirectory(_rootDir);

            var filePath = Path.Combine(_rootDir, fileName);

            using (var memoryStream = new MemoryStream())
            {
                await stream.CopyToAsync(memoryStream);
                File.WriteAllBytes(filePath, memoryStream.ToArray());
            }

            return filePath;
        }
    }
}