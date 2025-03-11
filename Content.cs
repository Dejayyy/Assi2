using System;

namespace Assi2
{
    abstract class Content 
    {
        public virtual void Print()
        {
            Console.WriteLine("Title: " + GetPrintableTitle());
            Console.WriteLine("Body: " + GetPrintableBody());
            Console.WriteLine();
        }

        protected abstract string GetPrintableTitle();
        protected abstract string GetPrintableBody();
        public abstract Content Clone();
    }
}
