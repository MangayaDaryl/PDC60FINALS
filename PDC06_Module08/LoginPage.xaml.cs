using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using static PDC06_Module08.SearchPage;

namespace PDC06_Module08
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    { 

       
        public LoginPage()
        {
            InitializeComponent();
            
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {

            if(txtUsername.Text == "admin" && txtPassword.Text == "admin" +
                "")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Ops..", "Username or Password is incorret!", "Ok"); 
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {


        }
    }
}