using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int Population { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
