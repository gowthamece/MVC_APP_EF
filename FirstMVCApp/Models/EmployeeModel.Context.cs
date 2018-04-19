﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstMVCApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Collections.Generic;

    public partial class EmployeeEntities : DbContext
    {
        public EmployeeEntities()
            : base("name=EmployeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
    
        public virtual int Stp_AddNewEmpDetails(string firstName, string lastName, string email, string password, string age)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var ageParameter = age != null ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Stp_AddNewEmpDetails", firstNameParameter, lastNameParameter, emailParameter, passwordParameter, ageParameter);
        }
    
        public virtual int stp_DeleteEmpById(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_DeleteEmpById", empIdParameter);
        }
    
        public virtual ObjectResult<stp_GetEmployees_Result> stp_GetEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetEmployees_Result>("stp_GetEmployees");
        }
    
        public virtual int stp_UpdateEmpDetails(Nullable<int> empId, string firstName, string lastName, string email, string password, string age)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var ageParameter = age != null ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_UpdateEmpDetails", empIdParameter, firstNameParameter, lastNameParameter, emailParameter, passwordParameter, ageParameter);
        }
    
        public virtual List<string> stp_Get_Emp_FirstName(Nullable<int> empID)
        {
            var empIDParameter = empID.HasValue ?
                new ObjectParameter("EmpID", empID) :
                new ObjectParameter("EmpID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("stp_Get_Emp_FirstName", empIDParameter).ToList();
        }
    }
}
