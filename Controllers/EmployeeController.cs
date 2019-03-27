using EmployeeData.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeData.DataAccess;

namespace EmployeeData.Controllers
{
    public class EmployeeController : ControllerBase
    {
         public EmployeeDataAccess DataAccess { get; set; }
        [HttpGet]
        public IEnumerable<Employee> GetData()
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            return employeeDataAccess.GetAllEmployees();
        }

        [HttpPost]
        [Route("create")]
        public IEnumerable<Employee> AddData(Employee employee)
        {
            EmployeeDataAccess dataAccess = new EmployeeDataAccess();
             dataAccess.AddEmployee(employee);
            return dataAccess.GetAllEmployees();
        }
    }
}