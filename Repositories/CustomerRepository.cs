using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;

namespace CoreDepartmentProject.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
    }
}
