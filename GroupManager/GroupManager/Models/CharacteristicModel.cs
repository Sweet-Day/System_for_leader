﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GroupManager.Models
{
    public class CharacteristicModel
    {
        public string Name { get; set; }
        public string Lastname { get;set; }
        public string Patronymic { get; set; }
        public string StartStudyDate { get; set; }
        public string Specialization { get; set; }
        public string Course { get; set;}
        public string Group { get; set; }
        public List<string> StudentRecomendations { get; set; }=new List<string>();
        public string PhysicalCharacteristic { get; set; }
        public string Collective { get; set; }
    }
}
