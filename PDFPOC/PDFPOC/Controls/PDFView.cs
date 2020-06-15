using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PDFPOC.Controls
{
    public class PDFView: WebView
    {
        public static readonly BindableProperty UriProperty = BindableProperty.Create(propertyName: "Uri",
                returnType: typeof(string),
                declaringType: typeof(PDFView),
                defaultValue: default(string));

        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }

        public static readonly BindableProperty IsPDFProperty = BindableProperty.Create(propertyName: "IsPDF",
                returnType: typeof(bool),
                declaringType: typeof(PDFView),
                defaultValue: default(bool));

        public bool IsPDF
        {
            get { return (bool)GetValue(IsPDFProperty); }
            set { SetValue(IsPDFProperty, value); }
        }

    }
}
