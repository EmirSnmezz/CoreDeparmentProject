using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;

namespace CoreDepartmentProject.Repositories.Concrete.BaseRepository
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
    }
}
