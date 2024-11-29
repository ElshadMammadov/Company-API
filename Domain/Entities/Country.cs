using Domain.Comman;

namespace Domain.Entities
{
    public class Country : BaseEntity
    {
      
        public string Name { get; set; }
        public int Population { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public List<City> Cities { get; set; }
    }
}
