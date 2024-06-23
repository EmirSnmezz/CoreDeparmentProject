namespace CoreDepartmentProject.Core.Utilities.DataResults
{
    public class SuccessDataResult<T> : DataResult<T> where T : class
    {
        public SuccessDataResult(T data, string message) : base(data, message, true)
        {
        }

        public SuccessDataResult(T data, bool isSuccess) : base(data, true)
        {
        }
    }
}
