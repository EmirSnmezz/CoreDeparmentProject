
using CoreDepartmentProject.Core.Constants.Results;

namespace CoreDepartmentProject.Core.Utilities.DataResults
{
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public DataResult(T data, string message, bool isSuccess) :base(isSuccess,message)
        {
            Data = data;
        }

        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
