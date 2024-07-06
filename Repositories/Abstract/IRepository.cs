using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Abstract;

namespace CoreDepartmentProject.Repositories.Abstract
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        public IResultt Add(T entity);
        public IResultt Update(T entity);
        public IResultt Delete(T entity);
        public IDataResult<List<T>> GetAll();
        public IDataResult<T> GetEntity(int Id);
    }
}
