using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliationSignature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class assinatura : ContentPage
    {
        public assinatura()
        {
            InitializeComponent();

           //DisplayOrientation.Landscape;
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            await Navigation.PushModalAsync(new MainPage(), false);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PadView.Clear();
        }
    }
}