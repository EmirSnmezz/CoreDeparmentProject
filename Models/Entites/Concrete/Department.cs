using CoreDepartmentProject.Models.Entites.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartmentProject.Models.Entites.Concrete
{
    public class Department : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
