//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Company.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Employees1 = new HashSet<Employee>();
            this.Reports = new HashSet<Report>();
            this.Projects = new HashSet<Project>();
        }
    
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal YearSalary { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public int DepartmentId { get; set; }
    
        public virtual ICollection<Employee> Employees1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}