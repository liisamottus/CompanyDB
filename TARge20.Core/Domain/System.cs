using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TARge20.Core.Domain
{
    public class Systems
    {
        [Key]
        public Guid Id { get; set; }
        public string SystemName { get; set; }

        public Guid AccessRightsId { get; set; }
        public AccessRights AccessRights { get; set; }
    }
}
