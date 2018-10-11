using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRecorder
{
    public class Receipt
    {
        public int Id { get; set; }
        public String Requirements { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public String Total { get { return String.Format("{0}$",Price * Quantity); } }

    }
}
