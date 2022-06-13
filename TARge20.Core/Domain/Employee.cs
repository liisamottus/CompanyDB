﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PersonalId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime WorkingSince { get; set; }
        public DateTime WorkingUntil { get; set; }

        public Guid BranchOfficeId { get; set; }
        public BranchOffice BranchOffice { get; set; }

        public List<Children> Childrens { get; set; }
        public List<HealthCheckUp> HealthCheckUps { get; set; }
        public List<SickLeave> SickLeaves { get; set; }
        public List<JobTitle> JobTitles { get; set; }
        public List<Vacation> Vacations { get; set; }
        public List<AccessRights> AccessRights { get; set; }
        public List<Items> Items { get; set; }




    }
}
