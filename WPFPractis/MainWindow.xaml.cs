using ClassLibraryTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPractis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Staffs _currentStaff = new Staffs();
        private Users _currentUser = new Users();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Regist_Click(object sender, RoutedEventArgs e)
        {
            var actual = TestClass.Validate(FirstName.Text, LastName.Text,  Passport.Text, Phone.Text, Email.Text, Login.Text, Password.Text);
            if (actual)
            {
                try
                {
                    _currentStaff.FirstName = FirstName.Text;
                    _currentStaff.LastName = LastName.Text;
                   
                    _currentStaff.Phone = Phone.Text;
                    _currentStaff.Passport = Passport.Text;
                    _currentStaff.Email = Email.Text;
                    _currentUser.Login = Login.Text;
                    _currentUser.Password = Password.Text;
                    SaleComponentsEntities1.getContext().Staffs.Add(_currentStaff);
                    SaleComponentsEntities1.getContext().SaveChanges();
                    MessageBox.Show("Данные записанны");
                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show(TestClass.Errors);
            }

            
        }
    }
}
