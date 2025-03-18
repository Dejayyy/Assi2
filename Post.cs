using System;

namespace Assi2
{
    //Post class inherits from Content
    class Post : Content
    {
        //Members
        public string Title;
        public string Body;

        //Default cstor with parameters
        public Post(string t, string b) {
            this.Title = t;
            this.Body = b;
        }

        //Default cstor w/o parameters
        public Post() : this("Default Title", "Default Body")
        {
        }

        //Print template method that cant be overidden
        public sealed override void Print()
        {
            base.Print();
        }

        //Clone implementation for Post
        public override Content Clone()
        {
            Post n = new Post();
            n.Title = this.Title;
            n.Body = this.Body;
            return n;
        }

        //Override for GetPrintableBody()
        public override string GetPrintableBody()
        {
            return Body;
        }

        //Override for GetPrintableTitle()
        public override string GetPrintableTitle()
        {
            return Title;
        }
    }
}
