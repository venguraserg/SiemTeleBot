using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7PLC_TeleBot_WPF.ViewModel.Base;


namespace S7PLC_TeleBot_WPF.ViewModel
{
    public class MainWindowViewModel : ViewModelAbstract
    {
        private string myVar;

        public string MyProperty
        {
            get => myVar;
            set => Set(ref myVar, value);
        }

        public ObservableCollection<string> Collection { get; set; }
        public ObservableCollection<string> Collection1 { get; set; }
        public MainWindowViewModel()
        {
            Collection = new ObservableCollection<string>();
            Collection.Add("1");
            Collection.Add("2");
            Collection.Add("3");
            Collection.Add("4");
            Collection.Add("5");

            Collection1 = new ObservableCollection<string>();
            Collection1.Add("5");
            Collection1.Add("4");
            Collection1.Add("3");
            Collection1.Add("2");
            Collection1.Add("1");
        }

        
    }
}
