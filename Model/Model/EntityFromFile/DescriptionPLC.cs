using S7.Net;
using System;


namespace Model.Model.EntityFromFile
{
    public class DescriptionPLC
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CpuType CpuType { get; set; }
        public string IpAdress { get; set; }
        public short Rack { get; set; }
        public short Slot { get; set; }

        public DescriptionPLC()
        {

        }

        public DescriptionPLC(Guid id, string name, CpuType cpuType, string ip, short rack, short slot)
        {
            Id = id;
            Name = name;
            CpuType = cpuType;
            IpAdress = ip;
            Rack = rack;
            Slot = slot;
        }

    }
}
