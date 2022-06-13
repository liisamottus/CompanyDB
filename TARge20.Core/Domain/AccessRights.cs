using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessRights
    {
        [Key]
        public Guid Id { get; set; }
        public string AccessName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<Systems> Systems { get; set; }
    }
}