﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Models
{
    public class Personnel
    {
        public int PersonnelId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
