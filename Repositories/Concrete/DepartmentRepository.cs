using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;

namespace CoreDepartmentProject.Repositories.Concrete
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
    }
}
