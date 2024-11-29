using Domain.Comman;

namespace Domain.Entities
{
    public class Job : BaseEntity
    {

        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public List<JobHistory> JobHistories { get; set; }
    }
}
