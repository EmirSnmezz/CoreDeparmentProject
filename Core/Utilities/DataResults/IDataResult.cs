using CoreDepartmentProject.Core.Constants.Results;

namespace CoreDepartmentProject.Core.Utilities.DataResults
{
    public interface IDataResult<T> : IResultt where T : class
    {
        public T Data { get; }
    }
}
