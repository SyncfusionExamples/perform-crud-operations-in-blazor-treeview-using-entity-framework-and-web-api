using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Shared.Models;

namespace MyBlazorApp.Shared.DataAccess
{
    public interface IOrganizationDataAccessLayer
    {
        IEnumerable<OrganizationDetails> GetAllEmployees();
        void AddEmployee(OrganizationDetails Employee);
        void UpdateEmployee(OrganizationDetails Employee);
        void DeleteEmployee(int id);
        void DeleteChildEmployee(int id);
        object GetIndex(string id);
    }

    public class OrganizationDataAccessLayer : IOrganizationDataAccessLayer
    {
        private readonly OrganizationContext _context;
        private List<OrganizationDetails> childEmployeeList = new List<OrganizationDetails>();

        public OrganizationDataAccessLayer(OrganizationContext context)
        {
            _context = context;
        }

        // returns the organization data from the data base
        public IEnumerable<OrganizationDetails> GetAllEmployees()
        {
            try
            {
                return _context.Organization.ToList();
            }
            catch
            {
                throw;
            }
        }

        // Adds the new entry to the data base
        public void AddEmployee(OrganizationDetails Employee)
        {
            try
            {
                _context.Organization.Add(Employee);
                OrganizationDetails ParentDetails = _context.Organization.Find(Employee.ParentId);
                if (ParentDetails != null)
                {
                    ParentDetails.HasTeam = true;
                }
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // Update the existing data in the data base
        public void UpdateEmployee(OrganizationDetails Employee)
        {
            try
            {
                _context.Entry(Employee).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // To delete an entry from the data base
        public void DeleteEmployee(int id)
        {
            try
            {
                OrganizationDetails Employee = _context.Organization.Find(id);
                _context.Organization.Remove(Employee);
                DeleteChildEmployee(id);
                _context.Organization.RemoveRange(childEmployeeList);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // To delete the nested child from the data base
        public void DeleteChildEmployee(int id)
        {
            try
            {
                var data = _context.Organization.ToList();
                for (int i = 0; i < data.Count(); i++)
                {
                    if (data[i].ParentId == id && childEmployeeList.Contains(data[i]) == false)
                    {
                        childEmployeeList.Add(data[i]);
                        if (data[i].HasTeam == true)
                        {
                            DeleteChildEmployee(data[i].Id);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public object GetIndex(string id)
        {
            var data = _context.Organization.ToList();
            int index;
            var count = data.Count;
            if (count > 0)
            {
                index = data[^1].Id;
            }
            else
            {
                index = 0;
            }
            return index;
        }
    }
}