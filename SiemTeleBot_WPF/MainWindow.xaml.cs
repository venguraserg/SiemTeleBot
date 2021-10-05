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

namespace SiemTeleBot_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<DataItemPLC> poolDataItemPLC = LoadSaveDataItemPLC.LoadDataItemPLC("123");
        
        public MainWindow()
        {
            InitializeComponent();
            ListDbView.ItemsSource = poolDataItemPLC;
        }
        int c = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ++c;
            poolDataItemPLC.Add(new DataItemPLC("sd", "sds", CpuType.S71200, "123.123.2.123", 0, 0, 5, 254, DataType.DataBlock, VarType.Real));
            //ListDbView.Items.Refresh();
        }

        
    }
}
