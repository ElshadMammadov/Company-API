using Domain.Comman;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
