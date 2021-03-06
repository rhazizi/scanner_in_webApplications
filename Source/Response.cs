using System.Collections.Generic;

namespace Scanner.Service
{

    public class Response
    {
        public Response(bool isSuccess, string message)
        {
            this.Message = message;
            this.IsSuccess = isSuccess;
        }
        public Response()
        {
            Result = new List<byte[]>();
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<byte[]> Result { get; set; }
    }
}
