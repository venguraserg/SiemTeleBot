using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using S7.Net;

namespace Model.Model
{
    public static class LoadSaveDataItemPLC
    {
        public static List<DataItemPLC> LoadDataItemPLC(string path)
        {
            if (File.Exists(path) == false)
            {
                using (File.Create(path)) { };                
            }
            bool isFileEmpty = string.IsNullOrEmpty(File.ReadAllText(path));

            if (isFileEmpty)
            {
                return new List<DataItemPLC>();
            }
            
            

            string json = File.ReadAllText(path);
            List<DescriptionDataItem>  dataPoints = JsonConvert.DeserializeObject<List<DescriptionDataItem>>(json);

            List<DataItemPLC> plcDataItems = new List<DataItemPLC>();

            for (int i = 0; i < dataPoints.Count; i++)
            {
                
                plcDataItems.Add(new DataItemPLC( dataPoints[i].Text, 
                                                  new Plc(dataPoints[i].CpuType, 
                                                          dataPoints[i].IpAdress, 
                                                          dataPoints[i].Rack, 
                                                          dataPoints[i].Slot),
                                                  dataPoints[i].Db,
                                                  dataPoints[i].StartByteAdr,
                                                  dataPoints[i].DataType, 
                                                  dataPoints[i].VarTypePLC));
            }

            return plcDataItems;
        }

        public static void SaveDataItemPLC(string path, List<DescriptionDataItem> descriptionDatas)
        {
            string json = JsonConvert.SerializeObject(descriptionDatas);
            File.WriteAllText(path, json);
        }





        //public static string[] GetDataPLC(DescriptionList dataItem)
        //{
        //    List<DataItemPLC> dataItemsPLC = new List<DataItemPLC>();

        //    for (int i = 0; i < dataItem.dataPoints.Count; i++)
        //    {
        //        dataItemsPLC.Add(new DataItemPLC(dataItem.dataPoints[i].Name, dataItem.dataPoints[i].Text, dataItem.dataPoints[i].CpuType, dataItem.dataPoints[i].IpAdress, dataItem.dataPoints[i].Rack, dataItem.dataPoints[i].Slot, dataItem.dataPoints[i].DataType, dataItem.dataPoints[i].VarTypePLC));
        //    }



        //    string[] dd = Array.Empty<string>();
        //    return dd;
        //}




    }
}
