using Domain.Comman;
using Domain.Entities;

namespace Domain.Entities
{
    public class Region : BaseEntity
    {
       
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
    }
}
