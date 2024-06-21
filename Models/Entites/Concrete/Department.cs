using CoreDepartmentProject.Models.Entites.Abstract;

namespace CoreDepartmentProject.Models.Entites.Concrete
{
    public class Department : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
