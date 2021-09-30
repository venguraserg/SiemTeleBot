using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class PollingPointSet
    {
        public List<DataItemPLC> dataPoints { get; set; }

        public PollingPointSet()
        {
            dataPoints = new List<DataItemPLC>();
        }
        



        public void AddPoint(DataItemPLC dataPoint)
        {
            dataPoints.Add(dataPoint);

        }

        /// <summary>
        /// Серилизация в Json
        /// </summary>
        /// <param name="сompany">структура компании которую серилизуем</param>
        /// <param name="path">путь к файлу</param>
        public void JsonSerialize(string path)
        {
            string json = JsonConvert.SerializeObject(this.dataPoints);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Десерилизация из json
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        public static List<DataItemPLC> JsonDeserialize(string path)
        {
            List<DataItemPLC> dataPoints = new List<DataItemPLC>();

            string json = File.ReadAllText(path);
            dataPoints = JsonConvert.DeserializeObject<List<DataItemPLC>>(json);

            return dataPoints;
        }
    }
}
