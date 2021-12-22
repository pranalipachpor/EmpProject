namespace EmpProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [StringLength(50)]
        public string EmpName { get; set; }

        public int? EmpSalary { get; set; }
    }
}
