using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Items
    {
        [Key]
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public Boolean Availability { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}