using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeStoreApp.BusinessClass;
using EmployeeStoreApp.DBModule.DAO;

namespace EmployeeStoreApp.DBModule.DBGateway
{
    class EmployeeGateway
    {
        private const string myConnectionString =
            @"data source=LAB2\SQLEXPRESS; initial catalog=EmployeeDB; integrated security=true;";
        private SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
        private SqlCommand aSqlCommand;
        private SqlDataReader aSqlDataReader;

        public void AddEmployee(Employee anEmployee)
        {
            string insertQuery = "insert into tbl_employee values('" + anEmployee.Name + "','" + anEmployee.Email +
                                 "','" + anEmployee.Address + "','" + anEmployee.Designation.Id+"')";
            mySqlConnection.Open();
            aSqlCommand = new SqlCommand(insertQuery, mySqlConnection);
            aSqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            string selectQuery = "select * from tbl_employee";
            mySqlConnection.Open();
            aSqlCommand = new SqlCommand(selectQuery, mySqlConnection);
            aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                Employee employeeFound = new Employee();
                employeeFound.Serial = Convert.ToInt32(aSqlDataReader["serial"]);
                employeeFound.Name = aSqlDataReader["name"].ToString();
                employeeFound.Email = aSqlDataReader["email"].ToString();
                employeeFound.Address = aSqlDataReader["address"].ToString();
                employeeFound.Designation =
                    new DesignationGateway().GetDesignation(Convert.ToInt32(aSqlDataReader["designationId"]));
                employees.Add(employeeFound);
            }
            mySqlConnection.Close();
            return employees;
        }

        public Employee GetEmployee(string employeeEmail)
        {
            foreach (Employee employee in GetEmployeeList())
            {
                if (employee.Email == employeeEmail)
                    return employee;
            }
            return null;
        }

        public List<Employee> FindEmployeesByName(string name)
        {
            List<Employee> searchEmployees=new List<Employee>();
            string selectQuery = "select * from tbl_employee where name='" + name + "'";
            mySqlConnection.Open();
            aSqlCommand = new SqlCommand(selectQuery, mySqlConnection);
            aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                Employee anEmployee=new Employee();
                anEmployee.Serial = Convert.ToInt32(aSqlDataReader["serial"]);
                anEmployee.Name = aSqlDataReader["name"].ToString();
                anEmployee.Email = aSqlDataReader["email"].ToString();
                anEmployee.Address = aSqlDataReader["address"].ToString();
                anEmployee.Designation = new DesignationGateway().GetDesignation(Convert.ToInt32(aSqlDataReader["designationId"]));
                searchEmployees.Add(anEmployee);
            }
            mySqlConnection.Close();
            return searchEmployees;
        }

        public void RemoveEmployee(Employee anEmployee)
        {
            string deleteQuery = "delete from tbl_employee where serial=" + anEmployee.Serial;
            aSqlCommand = new SqlCommand(deleteQuery, mySqlConnection);
            aSqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

    }
}
