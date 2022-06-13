using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }
        public string RegistrationNr { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Foreign key 
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Employee> Employees { get; set; }
    }


}
