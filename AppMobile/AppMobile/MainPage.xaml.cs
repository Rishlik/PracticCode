using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ClassLibraryTest;
using System.Net;
using Newtonsoft.Json;

namespace AppMobile
{
    
    public partial class MainPage : ContentPage
    {
        private ClassEditcs _context = new ClassEditcs();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool rt = TestClass.Validate(FirtsName.Text, LastName.Text, Passport.Text, Phone.Text, Email.Text, Login.Text, Password.Text);
            //finish
            if (!rt)
            {
                DisplayAlert("Ошибки при обработке данных", TestClass.Errors, "Ясно");
            }
            else
            {
                _context.FirstName = FirtsName.Text;
                _context.LastName = LastName.Text;
                _context.Passport = Passport.Text;
                _context.Phone = Phone.Text;
                _context.Email = Email.Text;
                _context.Login = Login.Text;
                _context.Password = Password.Text;
                
                try
                {
                    var client = new WebClient();
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    var result = client.UploadString("http://10.0.2.2:58409/api/Staff", JsonConvert.SerializeObject(_context));
                    DisplayAlert("Запись в бд", "Запись в бд успешно выполненна", "Ок");
                }
                catch (Exception Ex)
                {
                    DisplayAlert("Запись в бд", Ex.Message.ToString(), "Ясно");
                }
            }
        }
    }
}
