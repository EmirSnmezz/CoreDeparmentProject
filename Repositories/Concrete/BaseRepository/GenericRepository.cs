using CoreDepartmentProject.Core.Constants;
using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Core.Utilities.Results;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Abstract;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;

namespace CoreDepartmentProject.Repositories.Concrete.BaseRepository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        public IResultt Add(T entity)
        {
            if (entity == null)
            {
                return new ErrorResult(Messages.errorAddMessage);
            }
            using (Context _context = new Context())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            return new SuccessResult(Messages.successAddMessage);
        }


        public IResultt Delete(T entity)
        {
            if (entity == null)
            {
                return new ErrorResult(Messages.errorDeleteMessage);
            }
            using (Context _context = new Context())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }

            return new SuccessResult(Messages.successDeleteMessage);
        }

        public IResultt Update(T entity)
        {
            using (Context _context = new Context())
            {
                var updatedData = _context.Entry(entity);
                if (entity == null)
                {
                    return new ErrorResult(Messages.errorUpdateMessage);
                }

                updatedData.State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
                _context.SaveChanges();
            }

            return new SuccessResult(Messages.successUpdateMessage);
        }

        public IDataResult<List<T>> GetAll()
        {
            using(Context _context = new Context())
            {
                var result = _context.Set<T>().ToList();
                if(result == null)
                {
                    return new ErrorDataResult<List<T>>(result, Messages.GetDataErrorMessage);
                }
                return new SuccessDataResult<List<T>>(result, Messages.GetDataSuccessMessage);
   
            }
        }

        public IDataResult<T> GetEntity(int id)
        {
            using (Context _context = new Context())
            {
                var result = _context.Set<T>().Find(id);
                if (result == null)
                {
                    return new ErrorDataResult<T>(result, Messages.GetDataErrorMessage);
                }

                return new SuccessDataResult<T>(result, Messages.GetDataSuccessMessage);
            }
        }
    }
}
