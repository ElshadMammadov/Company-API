using Domain.Comman;

namespace Domain.Entities
{
    public class Job : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
    }
}
