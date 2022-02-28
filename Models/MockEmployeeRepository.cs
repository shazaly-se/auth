using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1,Name="SHAZALY",Email="shazaly.se@gmail.com",Department=Dept.SE},
                new Employee() {Id=2,Name="HAMZA",Email="hamza.is@gmail.com",Department=Dept.IS},
                new Employee() {Id=3,Name="Halem",Email="halem.net@gmail.com",Department=Dept.IT},
                 new Employee() {Id=4,Name="mohamed",Email="mohamed.is@gmail.com",Department=Dept.CS},
                new Employee() {Id=5,Name="mustafa",Email="mustafa.it@gmail.com",Department=Dept.IT},
                new Employee() {Id=6,Name="tenesh",Email="tenesh.net@gmail.com",Department=Dept.IT}
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {

            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
