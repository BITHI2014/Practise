using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeStoreApp.DBModule.DAO;
using EmployeeStoreApp.DBModule.DBGateway;

namespace EmployeeStoreApp.BusinessClass
{
    class EmployeeManager
    {

        private DesignationGateway aDesignationGateway = new DesignationGateway();
        private EmployeeGateway anEmployeeGateway=new EmployeeGateway();
        public void AddDesignation(Designation aDesignation)
        {
            if (aDesignationGateway.GetDesignation(aDesignation.Code) != null)
                throw new DuplicateDesignationCodeException();
            aDesignationGateway.AddDesignation(aDesignation);
        }

        public Designation[] GetAllDesignations()
        {
            return aDesignationGateway.GetDesignationList().ToArray();
        }

        public void AddEmployee(Employee employeeToBeAdded)
        {
            if (anEmployeeGateway.GetEmployee(employeeToBeAdded.Email) != null)
                throw new DuplicateEmployeeEmailException();
            anEmployeeGateway.AddEmployee(employeeToBeAdded);
        }

        public Employee[] GetAllEmployees()
        {
            return anEmployeeGateway.GetEmployeeList().ToArray();
        }

        public void RemoveEmployee(Employee employeeToBeRemoved)
        {
            if (anEmployeeGateway.GetEmployee(employeeToBeRemoved.Email) == null)
                throw new EmployeeNotFoundException();
            anEmployeeGateway.RemoveEmployee(employeeToBeRemoved);
        }

        public Employee[] GetEmployeesByName(string name)
        {
            return anEmployeeGateway.FindEmployeesByName(name).ToArray();
        }
    }

    class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() : base("Employee Not Found.")
        { }
    }

    class DuplicateEmployeeEmailException : Exception
    {
        public DuplicateEmployeeEmailException():base("An Employee with same email is already exist.")
        { }
    }

    class DuplicateDesignationCodeException : Exception
    {
        public DuplicateDesignationCodeException():base("A designation with same Code is already exist.")
        { }
    }
}
