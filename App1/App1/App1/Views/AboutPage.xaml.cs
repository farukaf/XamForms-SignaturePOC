using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void btn_Save_Clicked(object sender, EventArgs e)
        {
            byte[] imageArray = null;
            using (var imageStream = await sig_view1.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Jpeg))
            using (var memoryStream = new MemoryStream())
            {
                imageStream.CopyTo(memoryStream);
                imageArray = memoryStream.ToArray();
                //Send imageArray to API/Server
            }

            await DisplayAlert("Atenção", "Assinatura salva com sucesso", "OK");
            //Clear signature
            sig_view1.Clear();
        }
    }
}