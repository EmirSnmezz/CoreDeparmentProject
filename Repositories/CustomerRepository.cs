using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Dtos.Concrete;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDepartmentProject.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public  List<CustomerDto> GetAllDto()
        {
            
            using (Context context = new Context())
            {
                var data = (from customerdata in context.Customers
                            join departmentdata in context.Departments
                            on customerdata.DepartmentId equals departmentdata.ID
                            select new CustomerDto
                            {
                                Id = customerdata.ID,
                                CustomerName = customerdata.FirstName,
                                CustomerLastName = customerdata.LastName,
                                CustomerCity = customerdata.City,
                                DepartmentName = departmentdata.Name
                            }).ToList() ;
                return data ;

            }
        }
    }
}
