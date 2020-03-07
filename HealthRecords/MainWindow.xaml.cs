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

namespace HealthRecords
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

        //first grid buttons
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void quitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clrBtn_Click(object sender, RoutedEventArgs e)
        {
            string empty = "";
           
        }

        //Patient Name Boxes
        private void fNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Patient Records information
        private void ptAccnt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void gndrBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void wghtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void hghtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
