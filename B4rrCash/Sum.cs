using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    interface IExpression
    {
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
