using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PLC_Reader
    {
        const string path = "defaultBasePLC.json";
        public ObservableCollection<PLC_str> plc_list { get; set; } = new ObservableCollection<PLC_str>();


        public PLC_Reader()
        {
            var jsonData = JsonDeserialize(path);
            if (jsonData != null) this.plc_list = jsonData;
        }

        public void AddPLC(string name, int typeCpu, string ipAdress)
        {
            this.plc_list.Add(new PLC_str(name,typeCpu,ipAdress));
            JsonSerialize(this.plc_list, path);
        }
        public bool AddDataPoint(string ipAdress, string nanePoint, int dbNumber, int dbAdress, /*int dataType,*/ string text)
        {
            var plc = this.plc_list.FirstOrDefault(e => e.IP_Adress == ipAdress);
            if (plc == null)
            {
                return false; 
            }

            var index = plc_list.IndexOf(plc);
            this.plc_list[index].DataArr.Add(new PLC_DataPoint(nanePoint, dbNumber, dbAdress, /*dataType,*/ text));
            Save();
            return true;
        }
        public void Save()
        {
            JsonSerialize(this.plc_list, path);
        }
        public string Read()
        {



            
            return "";
        }


















        /// <summary>
        /// Серилизация в Json
        /// </summary>
        /// <param name="сompany">структура компании которую серилизуем</param>
        /// <param name="path">путь к файлу</param>
        internal static void JsonSerialize(ObservableCollection<PLC_str> plcList, string path)
        {

            string json = JsonConvert.SerializeObject(plcList);
            
            if (File.Exists(path) == false)
            {
                using (File.Create(path)) { };
            }
            
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Десерилизация из json
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        internal static ObservableCollection<PLC_str> JsonDeserialize(string path)
        {
            if (File.Exists(path) == false)
            {
                using (File.Create(path)) { };                
            }

            string json = File.ReadAllText(path);
            var tempplc = JsonConvert.DeserializeObject<ObservableCollection<PLC_str>>(json);

            return tempplc;
        }

    }
}
