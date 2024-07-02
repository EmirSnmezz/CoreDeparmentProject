using CoreDepartmentProject.Models.Entites.Abstract;

namespace CoreDepartmentProject.Models.Entites.Concrete
{
    public class Admin : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
