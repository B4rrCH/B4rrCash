using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    abstract class Expression
    {
        public static Sum operator +(Expression ex1, Expression ex2) => new Sum(ex1, ex2);
    }

    class Sum : Expression
    {
        public Expression Augend;
        public Expression Addend;

        public Sum(Expression augend, Expression addend)
        {
            Augend = augend;
            Addend = addend;
        }
    }
}
