using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Models.Dtos.Concrete;
using CoreDepartmentProject.Models.Entites.Concrete;

namespace CoreDepartmentProject.Repositories.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public List<CustomerDto> GetAllDto();
    }
}
