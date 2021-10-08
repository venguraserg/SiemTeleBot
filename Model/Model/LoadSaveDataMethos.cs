using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model.EntityForProgram;
using Model.Model.EntityFromFile;
using Newtonsoft.Json;
using S7.Net;

namespace Model.Model
{
    public static class LoadSaveDataMethos
    {
        public static MyDataBase GetDataFromFile(string path)
        {
            if (File.Exists(path) == false)
            {
                using (File.Create(path)) { };
            }
            bool isFileEmpty = string.IsNullOrEmpty(File.ReadAllText(path));

            if (isFileEmpty)
            {
                return new MyDataBase();
            }

            string json = File.ReadAllText(path);

            DataFile dataFromFile = JsonConvert.DeserializeObject<DataFile>(json);
            MyDataBase db = new MyDataBase();

            for (int i = 0; i < dataFromFile.descriptionPLCs.Count; i++)
            {
                db.Plc.Add(new MyPLC(dataFromFile.descriptionPLCs[i].Name,
                                     dataFromFile.descriptionPLCs[i].Id,
                                     new Plc(dataFromFile.descriptionPLCs[i].CpuType,
                                             dataFromFile.descriptionPLCs[i].IpAdress,
                                             dataFromFile.descriptionPLCs[i].Rack,
                                             dataFromFile.descriptionPLCs[i].Slot)));
            }



            for (int i = 0; i < dataFromFile.descriptionDataItems.Count; i++)
            {
                db.dataItemPLCs.Add(new DataItemPLC(dataFromFile.descriptionDataItems[i].Text,
                                                    db.GetPlcById(dataFromFile.descriptionDataItems[i].IdPlc),
                                                    dataFromFile.descriptionDataItems[i].Db,
                                                    dataFromFile.descriptionDataItems[i].StartByteAdr,
                                                    dataFromFile.descriptionDataItems[i].DataType,
                                                    dataFromFile.descriptionDataItems[i].VarTypePLC));
            }

            return db;

        }

        public static void SaveDataFromFile(string path, MyDataBase db)
        {
            DataFile dataFile = new DataFile();

            for (int i = 0; i < db.Plc.Count; i++)
            {
                dataFile.descriptionPLCs.Add(new DescriptionPLC(db.Plc[i].Id,
                                                                db.Plc[i].Name,
                                                                db.Plc[i].Plc.CPU,
                                                                db.Plc[i].Plc.IP,
                                                                db.Plc[i].Plc.Rack,
                                                                db.Plc[i].Plc.Slot));
            }

            for (int i = 0; i < db.dataItemPLCs.Count; i++)
            {
                dataFile.descriptionDataItems.Add(new DescriptionDataItem(db.dataItemPLCs[i].Text,
                                                                          db.GetIdPlc(db.dataItemPLCs[i].Plc),
                                                                          db.dataItemPLCs[i].Db,
                                                                          db.dataItemPLCs[i].StartByteAdr,
                                                                          db.dataItemPLCs[i].DataType,
                                                                          db.dataItemPLCs[i].VarTypePLC));
            }
            
            
            
            
            
            
            string json = JsonConvert.SerializeObject(dataFile);
            File.WriteAllText(path, json);
        }











    }
}
