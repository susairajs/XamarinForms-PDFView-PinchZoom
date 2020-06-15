using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
namespace PDFPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFviewer1 : ContentPage
    {
        //string url = "https://qa2mgutilities.sisystems.com/ActivityDetail/GetJobActivityDetails?Activitytranid=440377&Activityid=414&LoginUserid=362969";
        string url = "https://qa2mobile.sisystems.com/Gateway/MyaccountService.svc/ERemittance/GetPDF?ERemittanceinfo=Y2FEaEE1SCtzNTVNeEhPQ3ZpWmRYdDFyeVgvM1VNQnRIZnBFME1PZGI1Sm5sbVpBa1B4UmxST1Z4Tnd5UVN1bC9KcE9tVXU3MVU5OWpzaC9KdkVMTkhQZUtoS0xRY3VlUEU4SVN6VEpZbnM9";
        public PDFviewer1()
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