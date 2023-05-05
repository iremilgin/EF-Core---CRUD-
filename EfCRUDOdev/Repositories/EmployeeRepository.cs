using EfCRUDOdev.Context;
using EfCRUDOdev.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCRUDOdev.Repositories
{
    internal class EmployeeRepository
    {
        public EmployeeRepository()
        {
            db = new NorthwindContext();
        }
        NorthwindContext db;

        public List<Employee>GetAllEmployees()
        {
            List<Employee> employees =db.Employees.ToList();
            return employees;
        }
    }
}
