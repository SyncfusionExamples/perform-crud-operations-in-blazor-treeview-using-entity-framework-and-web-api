using Microsoft.AspNetCore.Mvc;
using MyBlazorApp.Data;
using MyBlazorApp.Shared.DataAccess;

namespace MyBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        readonly IOrganizationDataAccessLayer _organization;

        public OrganizationController(IOrganizationDataAccessLayer organization)
        {
            _organization = organization;
        }

        [HttpGet]
        public object Get()
        {
            return _organization.GetAllEmployees(Request.Query);
        }

        [HttpPost]
        public void Post([FromBody]OrganizationDetails employee)
        {
            _organization.AddEmployee(employee);
        }

        [HttpPut]
        public object Put([FromBody]OrganizationDetails employee)
        {
            _organization.UpdateEmployee(employee);
            return employee;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _organization.DeleteEmployee(id);
        }

        [HttpGet("{id}")]
        public object GetIndex(string id)
        {
            return _organization.GetIndex(id);
        }
    }
}
