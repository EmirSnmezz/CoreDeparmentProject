namespace CoreDepartmentProject.Core.Constants.Results
{
    public class Result : IResultt
    {
        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            this.Message = message;
        }

        public Result(bool isSuccess)
        {
            this.IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; set ; }
        public string Message { get; set ; }
    }
}
