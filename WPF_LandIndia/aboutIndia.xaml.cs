using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WPF_LandIndia
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class aboutIndia : Window
    {
        public static ObservableCollection<Categories> _categories;
        public aboutIndia()
        {
            InitializeComponent();
        }
        public void Btn_AddCategories_Click(object sender, RoutedEventArgs e)
        {
            Categories cat = new Categories { categories = "History of India", history = "asigasikjbhfaskjghaskjg" };
            _categories.Add(cat);
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _categories = MyStorage.ReadXml<ObservableCollection<Categories>>("Categories.xml");
            Lbx_Categories.ItemsSource = _categories;
            Lbx_Categories.SelectedIndex = 0;
            if (_categories == null)
                _categories = new ObservableCollection<Categories>();
        }

        public void Window_Closed(object sender, EventArgs e)
        {
            MyStorage.WriteXml<ObservableCollection<Categories>>(_categories, "Categories.xml");
            Owner.Visibility = Visibility.Visible;
        }

       //private void Tbx_Filter_TextChanged(object sender, TextChangedEventArgs e)
       // {
           // if (Tbx_filter.Text == "")
           // {
             //   Lbx_Categories.ItemsSource = _categories;
             //   Lbx_Categories.SelectedIndex = 0;
           // }
           // else
           // {
             //   var filter = Tbx_filter.Text;
             //   var cate = (from c in _categories
               //             where c.categories.ToLower().Contains(filter)
                 //           select c).ToList();
              //  var cate2 = (from c in _categories
               //              where c.history.ToLower().Contains(filter)
               //              select c).ToList();
               // Lbx_Categories.ItemsSource = cate;
               // Lbx_Categories.ItemsSource = cate2;

           // }
       // }

    }
}