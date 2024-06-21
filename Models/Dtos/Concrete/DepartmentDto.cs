using CoreDepartmentProject.Models.Dtos.Abstract;

namespace CoreDepartmentProject.Models.Dtos.Concrete
{
    public class DepartmentDto : IDto
    {
            public int ID { get; set; }
            public string DepartmentName { get; set; }   
    }
}
