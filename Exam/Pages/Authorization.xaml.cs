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

namespace Exam.Pages
{
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private int _attemps;
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Pages.Registration());
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (TBNickname.Text.ToString() == "admin" && PBPassword.Password.ToString() == "admin")
            {
                App.MainFrame.Navigate(new Pages.Admin());
            }
            else
            {
                try
                {
                    var db = new ExamDBEntities1();
                    var user = db.users.AsNoTracking().FirstOrDefault(u => u.login == TBNickname.Text.ToString());
                    var pass = db.users.AsNoTracking().FirstOrDefault(u => u.login == TBNickname.Text.ToString() && u.password != PBPassword.Password.ToString());

                    if (string.IsNullOrEmpty(TBNickname.Text) || string.IsNullOrEmpty(PBPassword.Password))
                    {
                        MessageBox.Show("Введите никнейм и пароль!", "Ошибка Авторизации");
                        Login_Block();
                        return;
                    }
                    else if (user == null)
                    {
                        MessageBox.Show("Пользователь не найден!", "Ошибка Авторизации");
                        Login_Block();
                        return;
                    }
                    else if (pass != null)
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка Авторизации");
                        Login_Block();
                        return;
                    }
                    else
                        App.MainFrame.Navigate(new Pages.UserPage());
                }
                catch
                {
                    MessageBox.Show("Отсутствует подключение к базе данных", "Database Error");
                }
            }
        }
        private void PBPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBPassword.Password.Length > 0)
                TBPassword.Visibility = Visibility.Collapsed;
            else
                TBPassword.Visibility = Visibility.Visible;
        }

        private void TBTextChanged(object sender, RoutedEventArgs e)
        {
            if (TBNickname.Text.Length > 0)
                TBLogin.Visibility = Visibility.Collapsed;
            else
                TBLogin.Visibility = Visibility.Visible;
        }
        
        private async void Login_Block()
        {
            if (_attemps > 1)
            {
                Login.IsEnabled = false;
                ButtonBlocker.Visibility = Visibility.Visible;
                await Task.Delay(10000);
                Login.IsEnabled = true;
                ButtonBlocker.Visibility = Visibility.Collapsed;
            }
            _attemps += 1;
        }
    }
}
