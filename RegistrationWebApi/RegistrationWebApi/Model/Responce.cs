using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationWebApi.Model
{
    //public class Responce
    //{
        public class APIResponseStatus
        {
            public bool IsSuccess { get; set; }
            public string ErrorMessage { get; set; }
            public void SetBase(bool isSuccess, string errorMessage)
            {
                IsSuccess = isSuccess;
                ErrorMessage = errorMessage;
            }
        }
        public class APIResponse
        {
            public dynamic data { get; set; }
            public APIResponseStatus Status { get; set; }
            public DDl InsertedData { get; set; }
        }
        public class DDl
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    public class ErrorAPIResponse : APIResponseStatus
    {
        public ErrorAPIResponse()
        {
        }

        public ErrorAPIResponse(string message) : base()
        {
            base.IsSuccess = false;
            base.ErrorMessage = message;
        }
    }


}
//}
