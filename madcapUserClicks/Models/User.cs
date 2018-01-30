using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace madcapUserClicks.Models
{
    public class User
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public DateTime linkOpenedDate { get; set; }
    }
}
