using CoreDepartmentProject.Core.Constants;
using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.Results;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using System.Security.Claims;

namespace CoreDepartmentProject.Repositories.Concrete.BaseRepository
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public IResultt Login(Admin admin)
        {
            using (Context context = new Context())
            {
                var userInfo = context.Set<Admin>().FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);

                if (userInfo == null)
                {
                    return new ErrorResult(Messages.LoginErrorMessage);
                }

                return new SuccessResult(Messages.LoginSuccessMessage);
            }
        }
    }
}
