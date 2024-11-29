using Domain.Comman;

namespace Domain.Entities
{
    public class Location : BaseEntity
    {
        public string StreetAdress { get; set; }
        public string PostalCode { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
