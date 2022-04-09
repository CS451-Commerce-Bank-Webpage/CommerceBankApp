using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceBlazorServer.Models
{
    public class PersonModel
    {
        public string account_id { get; set; }
        public string processing_date { get; set; }
        public string balance { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
        public string location { get; set; }
        public string description{ get; set; }

    }
}