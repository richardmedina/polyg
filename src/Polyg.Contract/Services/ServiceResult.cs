using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Polyg.Contract.Services
{
    public class ServiceResult<TResult>
    {
        public TResult Result { get; set; }
        public string ErrorMessage { get; set; }
        public ServiceStatusCode StatusCode { get; set; }
    }
}
