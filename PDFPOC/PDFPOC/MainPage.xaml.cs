using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PDFPOC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
         string url = "http://10.1.15.123:8081/Help";
        // string url = "http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf";
        //string url = "https://qa2mgutilities.sisystems.com/ActivityDetail/GetJobActivityDetails?Activitytranid=440377&Activityid=414&LoginUserid=362969";
        public MainPage()
        {
            InitializeComponent();

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    pdfView.Uri = url;
            //    pdfView.On<Android>().EnableZoomControls(true);
            //    pdfView.On<Android>().DisplayZoomControls(false);
            //}

            //else
            //    pdfView.Source = url;


            //var fileName = Guid.NewGuid().ToString();
            //var dependency = DependencyService.Get<IFile>();
            //var localPath = string.Empty;
            //Task.Run(async() => await DownloadFile());
            //localPath = FileHelper.GetFilePath("ERemittance.pdf");
            //Webview.Source = "http://www.google.co.in";
            //webView.Source = "https://www.wikipedia.org/";
            //webView.Source = "http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf";
            //webView.On<Android>().EnableZoomControls(true);
            //webView.On<Android>().DisplayZoomControls(false);

            //if (string.IsNullOrWhiteSpace(localPath))
            //{
            //    return;
            //}


            //pdfView.Source = "https://www.wikipedia.org/";
            //pdfView.Uri = "http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf";
            //pdfView.On<Android>().EnableZoomControls(true);
            //pdfView.On<Android>().DisplayZoomControls(false);

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    pdfView.Source = $"file:///android_asset/pdfjs/web/viewer.html?file={"file:///" + WebUtility.UrlEncode(localPath)}";
            //    pdfView.On<Android>().EnableZoomControls(true);
            //    pdfView.On<Android>().DisplayZoomControls(false);
            //}

            //else
            //    pdfView.Source = url;
        }

        public async  Task DownloadFile()
        {
            await FileHelper.DownloadAndWriteIntoNewFile(url, "ERemittance.pdf");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PDFViewer());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PDFviewer1());
        }
    }
}
