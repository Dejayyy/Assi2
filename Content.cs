using System;

namespace Assi2
{
    //Abstract Content class
    abstract class Content 
    {
        //Template Print() method
        public virtual void Print()
        {
            Console.WriteLine("Title: " + GetPrintableTitle());
            Console.WriteLine("Body: " + GetPrintableBody());
            Console.WriteLine();
        }   
        //Helper function decls used in template
        public abstract string GetPrintableTitle();
        public abstract string GetPrintableBody();
        //Clone function decl
        public abstract Content Clone();
    }
}
