using System.Collections.Generic;

namespace InitsProject.DTO
{
    public class ResponseMessage
    {
        public ResponseMessage()
        {
            ErrorMessages = new List<string>();
        }
        public string status { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object data { get; set; }
    }
}
