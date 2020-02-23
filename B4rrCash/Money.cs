using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    abstract class Money
    {
        protected int Amount { get; set; }
        protected string Currency { get; set; }
    }
}
