using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Models
{
    public class ResponseModel
    {
        public object Request { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
    }
}
