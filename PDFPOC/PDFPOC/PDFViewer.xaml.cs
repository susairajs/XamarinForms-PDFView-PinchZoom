using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using System.Net.Http;
namespace PDFPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFViewer : ContentPage
    {
        string url = "http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf";
        public PDFViewer()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
            {
                pdfView.Uri = url;
                pdfView.On<Android>().EnableZoomControls(true);
                pdfView.On<Android>().DisplayZoomControls(false);
            }

            else
                pdfView.Source = url;
        }

    }
}