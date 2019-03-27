using EmployeeData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeData.DataAccess
{
    public class EmployeeDataAccess
    {
        string connectionString = "(localDB)/local";
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spGetAllEmployees",connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(sqlDataReader["EmployeeId"]);
                    employee.Name = sqlDataReader["Name"].ToString();
                    employee.City = sqlDataReader["City"].ToString();
                    employee.Department = sqlDataReader["Department"].ToString();
                    employee.Gender = sqlDataReader["Gender"].ToString();
                    employees.Add(employee);
                }
                connection.Close();
            }
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spAddEmployee", connection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name",employee.Name);
                sqlCommand.Parameters.AddWithValue("@City", employee.City);
                sqlCommand.Parameters.AddWithValue("@Department", employee.Department);
                sqlCommand.Parameters.AddWithValue("@Gender", employee.Gender);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}