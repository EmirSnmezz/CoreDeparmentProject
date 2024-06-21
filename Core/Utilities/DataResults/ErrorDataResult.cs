namespace CoreDepartmentProject.Core.Utilities.DataResults
{
    public class ErrorDataResult<T> : DataResult<T> where T : class
    {
        public ErrorDataResult(T data, string message) : base(data,message,false)
        {
        }

        public ErrorDataResult(T data) : base(data, false)
        {
        }
    }
}
