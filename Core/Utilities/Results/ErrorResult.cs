using CoreDepartmentProject.Core.Constants.Results;

namespace CoreDepartmentProject.Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message) 
        {
        }

        public ErrorResult(bool isSuccess) : base(false) 
        {
        }
    }
}
