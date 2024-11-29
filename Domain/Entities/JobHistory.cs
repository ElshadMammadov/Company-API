using Domain.Comman;

namespace Domain.Entities
{
    public class JobHistory : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate {  get; set; } 
        public DateTime EndDate { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
