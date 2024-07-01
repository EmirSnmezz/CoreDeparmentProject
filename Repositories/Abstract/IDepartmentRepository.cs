using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Models.Entites.Concrete;

namespace CoreDepartmentProject.Repositories.Abstract
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        public IDataResult<List<Customer>> GetCustomersById(int id);
    }
}
