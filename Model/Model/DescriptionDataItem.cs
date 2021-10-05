﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace Model.Model
{
    public class DescriptionDataItem
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public CpuType CpuType { get; set; }
        public string IpAdress { get; set; }
        public short Rack { get; set; }
        public short Slot { get; set; }
        public DataType DataType { get; set; }
        public VarType VarTypePLC { get; set; }

        public DescriptionDataItem()
        {

        }

        public DescriptionDataItem(string Name, string Text, CpuType CpuType, string IpAdress, short Rack, short Slot, DataType DataType, VarType VarTypePLC)
        {
            this.Name = Name;
            this.Text = Text;
            this.CpuType = CpuType;
            this.IpAdress = IpAdress;
            this.Rack = Rack;
            this.Slot = Slot;
            this.DataType = DataType;
            this.VarTypePLC = VarTypePLC;

        }
    }
}