using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name="Ram", Department="IT", Email="R@email.com"},
                new Employee() { Id = 2, Name="Sam", Department="HR", Email="R@email.com"},
                new Employee() { Id = 3, Name="Ham", Department="FIN", Email="R@email.com"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return this._employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
