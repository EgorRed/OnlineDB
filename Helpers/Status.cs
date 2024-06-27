using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public enum RequestStatus
    {
        OK,
        OK2,
        DataIsNull,
        DataIsNotFound,
        DataRepetition,
        AccessIsDenied
    }


    public class Status
    {
        public Status(RequestStatus _statusCode, string _description)
        {
            StatusCode = _statusCode;
            Description = _description;
        }
        public RequestStatus StatusCode { get; }
        public string Description { get; }
    }
}
