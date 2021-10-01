using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Angularjs_Relational_Database.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new List<Employee>();
        }
        public int DepartmentId { get; set; }
        [Required,StringLength(40)]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required, StringLength(40)]
        public string EmployeeName { get; set; }
        [Required, Column(TypeName ="date")]
        public DateTime JoinDate { get; set; }
        [Required,ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }

}
