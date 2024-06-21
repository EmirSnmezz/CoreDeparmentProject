using CoreDepartmentProject.Core.Constants.Results;

namespace CoreDepartmentProject.Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true,message)
        {
            this.Message = message;
        }
        
        public SuccessResult(bool isSucces) : base(true)
        {

        }
    }
}
