using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model.EntityFromFile
{
    public class DataFile
    {
        public List<DescriptionDataItem> descriptionDataItems { get; set; }
        public List<DescriptionPLC> descriptionPLCs { get; set; }

        public DataFile()
        {
            descriptionDataItems = new List<DescriptionDataItem>();
            descriptionPLCs = new List<DescriptionPLC>();
        }
        

    }
}
