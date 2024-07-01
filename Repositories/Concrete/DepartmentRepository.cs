using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Core.Constants;

namespace CoreDepartmentProject.Repositories.Concrete
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public IDataResult<List<Customer>> GetCustomersById(int id)
        {
            using (var context = new Context())
            {
                var data = context.Set<Customer>().Where(x => x.DepartmentId == id).ToList(); ;
                if (data == null)  return new ErrorDataResult<List<Customer>>(data, Messages.GetDataErrorMessage);
                return new SuccessDataResult<List<Customer>>(data, Messages.GetDataSuccessMessage);

            }
        }
    }

}
