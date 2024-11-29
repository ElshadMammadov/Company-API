using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public float Salary { get; set; }
        public int DepertamentId { get; set; }
        public string Image {  get; set; }
        public Department Department { get; set; }
        public ICollection<JobHistory> JobHisories { get; set; }

    }
}
