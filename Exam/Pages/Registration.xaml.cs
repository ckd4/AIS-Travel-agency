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
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void PBPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBPassword1.Password.Length > 0)
                TBPassword1.Visibility = Visibility.Collapsed;
            else
                TBPassword1.Visibility = Visibility.Visible;

            if (PBPassword2.Password.Length > 0)
                TBPassword2.Visibility = Visibility.Collapsed;
            else
                TBPassword2.Visibility = Visibility.Visible;
        }

        private void BTNRegistration_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new ExamDBEntities1();
                var user = db.users.AsNoTracking().FirstOrDefault(u => u.login == TBNicknameReg.Text);

                if (string.IsNullOrEmpty(TBNicknameReg.Text) || string.IsNullOrEmpty(PBPassword1.Password) || string.IsNullOrEmpty(PBPassword1.Password))
                {
                    MessageBox.Show("Введите никнейм и пароль!", "Ошибка Авторизации");
                    return;
                }
                else if (PBPassword1.Password != PBPassword2.Password)
                {
                    MessageBox.Show("Пароли должны совпадать!", "Ошибка Авторизации");
                    return;
                }
                else if (user != null)
                {
                    MessageBox.Show("Такой никнейм уже занят!", "Ошибка Авторизации");
                    return;
                }
                else
                {
                    try
                    {
                        users u = new users();
                        u.login = TBNicknameReg.Text;
                        u.password = PBPassword1.Password;
                        ExamDBEntities1.GetContext().users.Add(u);
                        ExamDBEntities1.GetContext().SaveChanges();
                        NavigationService.Navigate(new UserPage());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Отсутствует подключение к базе данных", "Database Error");
            }
        }

        private void TBTextChanged(object sender, RoutedEventArgs e)
        {
            if (TBNicknameReg.Text.Length > 0)
                TBLogin.Visibility = Visibility.Collapsed;
            else
                TBLogin.Visibility = Visibility.Visible;
        }

        private void BTNAuth_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Authorization());
        }
    }
}
    