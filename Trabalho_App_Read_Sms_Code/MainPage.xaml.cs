using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Trabalho_App_Read_Sms_Code
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<List<string>>(this, "MyMessage", (expense) =>
            {
                List<string> mylist = expense as List<string>;
                string allText = "";
                foreach (string item in mylist)
                {
                    allText += item + "  ";
                }
                editorSms.Text = allText;
            });
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            var p = await Permissions.CheckStatusAsync<Permissions.Sms>();

            if (p!=PermissionStatus.Granted)
            {
                p = await Permissions.RequestAsync<Permissions.Sms>();
            }
            if (p==PermissionStatus.Granted)
            {
                Xamarin.Forms.DependencyService.Get<ISmsReader>().GetSmsInbox();
            }

          
        }
    }
}
