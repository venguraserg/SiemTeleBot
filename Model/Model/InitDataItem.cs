using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace Model.Model
{
    public static class InitDataItem
    {
        public static string[] GetDataPLC(DescriptionList dataItem)
        {
            List<DataItemPLC> dataItemsPLC = new List<DataItemPLC>();

            for (int i = 0; i < dataItem.dataPoints.Count; i++)
            {
                dataItemsPLC.Add(new DataItemPLC(dataItem.dataPoints[i].Name, dataItem.dataPoints[i].Text, dataItem.dataPoints[i].CpuType, dataItem.dataPoints[i].IpAdress, dataItem.dataPoints[i].Rack, dataItem.dataPoints[i].Slot, dataItem.dataPoints[i].DataType, dataItem.dataPoints[i].VarTypePLC));
            }

            string[] messageMasive = new string[dataItemsPLC.Count];
            for (int i = 0; i < dataItemsPLC.Count; i++)
            {
                messageMasive[i] = dataItemsPLC[i].ReadDataPoint();
            }


            string[] dd = Array.Empty<string>();
            return dd;
        }




    }
}
