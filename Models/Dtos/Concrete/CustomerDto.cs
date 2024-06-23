using CoreDepartmentProject.Models.Dtos.Abstract;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDepartmentProject.Models.Dtos.Concrete
{
    public class CustomerDto : IDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCity { get; set; }
        public string DepartmentName { get; set; }
    }
}
