using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class DescriptionList
    {
        public List<DescriptionDataItem> dataPoints { get; set; }

        public DescriptionList()
        {
            dataPoints = new List<DescriptionDataItem>();
        }

        public void AddPoint(DescriptionDataItem dataPoint)
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
        public static List<DescriptionDataItem> JsonDeserialize(string path)
        {
            List<DescriptionDataItem> dataPoints = new List<DescriptionDataItem>();

            string json = File.ReadAllText(path);
            dataPoints = JsonConvert.DeserializeObject<List<DescriptionDataItem>>(json);

            return dataPoints;
        }

    }
}
