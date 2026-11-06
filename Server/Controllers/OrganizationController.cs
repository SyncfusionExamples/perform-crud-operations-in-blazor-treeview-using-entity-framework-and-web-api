using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using MyBlazorApp.Shared.DataAccess;
using MyBlazorApp.Shared.Models;

namespace MyBlazorApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationDataAccessLayer _organization;

        public OrganizationController(IOrganizationDataAccessLayer organization)
        {
            _organization = organization;
        }

        [HttpGet]
        public object Get()
        {
            // Get the DataSource from Database
            var data = _organization.GetAllEmployees().ToList();
            var queryString = Request.Query;
            if (queryString.Keys.Contains("$filter"))
            {
                StringValues Skip;
                StringValues Take;
                int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : data.Count();
                string filter = string.Join("", queryString["$filter"].ToString().Split(' ').Skip(2)); // get filter from querystring
                data = data.Where(d => d.ParentId.ToString() == filter).ToList();
                return data.Skip(skip).Take(top);
            }
            else
            {
                data = data.Where(d => d.ParentId == null).ToList();
                return data;
            }
        }

        [HttpPost]
        public void Post([FromBody] OrganizationDetails employee)
        {
            _organization.AddEmployee(employee);
        }

        [HttpPut]
        public object Put([FromBody] OrganizationDetails employee)
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