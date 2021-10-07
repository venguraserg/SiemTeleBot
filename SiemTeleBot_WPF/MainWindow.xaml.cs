using Model.Model;
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
using S7.Net;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SiemTeleBot_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<DataItemPLC> poolDataItemPLC = LoadSaveDataItemPLC.LoadDataItemPLC("123");
        Array f;
        

        public MainWindow()
        {
            InitializeComponent();
             f = Enum.GetValues(typeof(DataType));
           // CB_1.ItemsSource = f;        
        }

        private void CB_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //TB_1.Text = ((int)((DataType)CB_1.SelectedItem)).ToString();
           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Creator Info", "info");
        }
    }

   
    
}
