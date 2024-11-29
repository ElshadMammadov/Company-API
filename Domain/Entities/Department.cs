﻿using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Department : BaseEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int locationId  { get; set; }
        public Location location { get; set; }
    }
}
