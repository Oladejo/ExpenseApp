using System.Collections.Generic;

namespace InitsProject.DTO
{
    public class ResponseMessage
    {
        public ResponseMessage()
        {
            ErrorMessages = new List<string>();
        }
        public string Status { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Data { get; set; }
    }
}
