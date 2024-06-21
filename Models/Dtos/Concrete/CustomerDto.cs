using CoreDepartmentProject.Models.Dtos.Abstract;

namespace CoreDepartmentProject.Models.Dtos.Concrete
{
    public class CustomerDto : IDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DepartmentName { get; set; }
    }
}
