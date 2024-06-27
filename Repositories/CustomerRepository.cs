
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
        public List<CustomerDto> GetAllDto()
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
                            }).ToList();
                return data;

            }
        }
        public CustomerDto GetDetailOfDto(int id)
        {
            using (Context context = new Context())
            {
                CustomerDto data = (from customerdata in context.Customers
                                    join departmentData in context.Departments
                                    on customerdata.DepartmentId equals departmentData.ID
                                    where customerdata.ID == id
                                    select new CustomerDto
                                    {
                                        Id = customerdata.ID,
                                        CustomerName = customerdata.FirstName,
                                        CustomerLastName = customerdata.LastName,
                                        CustomerCity = customerdata.City,
                                        DepartmentName = departmentData.Name
                                    }).First(x => x.Id == id);

                if (data == null)
                {
                    throw new Exception("Null");
                }
                return data;
            }
        }

        public List<SelectListItem> SelectOfDepartmentData()
        {
            using (Context context = new Context())
            {
                var result = (from departmentdata in context.Departments.ToList()
                              select new SelectListItem
                              {
                                  Text = departmentdata.Name,
                                  Value = departmentdata.ID.ToString()
                              }).ToList();  

                if(result == null)
                {
                    throw new Exception("Null ");
                }

                return result;
            }
        }
    }
}

