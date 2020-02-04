using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyRobotsTools.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _emloyeeList;

        public MockEmployeeRepository()
        {
            _emloyeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name ="Mary", Department = "HR", Email = "Mary@test.com"},
                new Employee() {Id = 2, Name = "John", Department = "IT", Email = "John@test.com"},
                new Employee() {Id = 3, Name = "Sam", Department = "IT", Email = "Sam@test.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _emloyeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _emloyeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
