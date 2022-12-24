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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
            DGQ.ItemsSource = ExamDBEntities1.GetContext().places.ToList();
        }


        private void AddQ_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new ExamDBEntities1();
                places p = new places();
                p.city = TBGood.Text.ToString();
                p.hotel = TBHotel.Text.ToString();
                p.price = Convert.ToInt32(TBPrice.Text);
                p.picture = TBPicture.Text.ToString();
                ExamDBEntities1.GetContext().places.Add(p);
                ExamDBEntities1.GetContext().SaveChanges();
                MessageBox.Show("Your information added!", "Success");
            }
            catch
            {
                MessageBox.Show("Please try again!", "DataBase error");
            }

        }

            private void TBTextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBGood.Text.Length > 0)
                TBGood2.Visibility = Visibility.Collapsed;
            else
                TBGood2.Visibility = Visibility.Visible;

            if (TBPrice.Text.Length > 0)
                TBPrice2.Visibility = Visibility.Collapsed;
            else
                TBPrice2.Visibility = Visibility.Visible;

            if (TBPicture.Text.Length > 0)
                TBPicture2.Visibility = Visibility.Collapsed;
            else
                TBPicture2.Visibility = Visibility.Visible;

            if (TBHotel.Text.Length > 0)
                TBHotel2.Visibility = Visibility.Collapsed;
            else
                TBHotel2.Visibility = Visibility.Visible;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
