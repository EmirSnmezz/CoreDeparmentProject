using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Models.Dtos.Concrete;
using CoreDepartmentProject.Models.Entites.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDepartmentProject.Repositories.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public List<CustomerDto> GetAllDto();
        public CustomerDto GetDetailOfDto(int id);
        public List<SelectListItem> SelectOfDepartmentData();
    }
}
