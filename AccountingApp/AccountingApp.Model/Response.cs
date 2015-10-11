using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Model
{
    public class Response<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Attachment { get; set; }
    }
}
