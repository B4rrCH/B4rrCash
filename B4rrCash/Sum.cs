using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    abstract class IExpression
    {
        public static Sum operator +(IExpression ex1, IExpression ex2) => new Sum(ex1, ex2);
    }

    class Sum : IExpression
    {
        public IExpression Augend;
        public IExpression Addend;

        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }
    }
}
