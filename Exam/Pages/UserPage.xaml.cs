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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            DGQ.ItemsSource = ExamDBEntities1.GetContext().places.ToList();
        }

        private void DGQ_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var A = (places)DGQ.SelectedItem;
                Pic.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + A.picture, UriKind.Absolute));
            }
            catch
            {
                MessageBox.Show("Not found");
            }
        }

        private void AddQ_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"You have been successfully registrated at {DGQ.SelectedValue.ToString()}");
        }
    }
}
