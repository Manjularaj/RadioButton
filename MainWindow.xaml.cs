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

namespace RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheckBoxResult1_Click(object sender, RoutedEventArgs e)
        {
            //checkbox
            bool isChecked = CkFirstCheckBox.IsChecked.Value;

            MessageBox.Show(isChecked.ToString());
        }

        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {
            runReciept.Text = "";
            
            bool hasCorn = CkCorn.IsChecked.Value;

            if(hasCorn == true)
            {
                runReciept.Text += "Corn";
            }
            
      
        }

       
    }
}
