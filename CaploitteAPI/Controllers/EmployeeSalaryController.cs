using CaploitteAPI.Model;
using CaploitteAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaploitteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeSalaryController : ControllerBase
    {
        private readonly IDataHandlerRepository<Employee> _employeeRepository;
        private readonly IDataHandlerRepository<EmployeeSalaryDetails> _employeeSalaryRepository;
        public EmployeeSalaryController(IDataHandlerRepository<EmployeeSalaryDetails> salaryDataHandlerRepository,
            IDataHandlerRepository<Employee> employee)
        {
            _employeeSalaryRepository = salaryDataHandlerRepository;
            _employeeRepository = employee;
        }

        [HttpPost]
        public  IActionResult Post([FromBody] EmployeeSalaryDetails details)
        {
            var employeeDetail = _employeeRepository.GetById(details.Employee.EmployeeId);
            details.Employee = employeeDetail;

            int id = _employeeSalaryRepository.Add(details);
            return Ok(id);
        }  

    }
}
