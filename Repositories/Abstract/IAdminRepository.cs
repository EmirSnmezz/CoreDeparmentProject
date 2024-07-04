using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Models.Entites.Concrete;

namespace CoreDepartmentProject.Repositories.Abstract
{
    public interface IAdminRepository : IRepository<Admin>
    {
        public IResultt Login(Admin admin);
    }
}
