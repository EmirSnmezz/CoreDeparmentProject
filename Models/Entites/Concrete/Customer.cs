using CoreDepartmentProject.Models.Entites.Abstract;

namespace CoreDepartmentProject.Models.Entites.Concrete
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }
    }
}
