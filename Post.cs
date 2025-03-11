using System;

namespace Assi2
{
    class Post : Content
    {
        public string Title;
        public string Body;

        public Post(string t, string b) {
            this.Title = t;
            this.Body = b;
        }

        public Post() : this("Default Title", "Default Body")
        {
        }

        public sealed override void Print()
        {
            base.Print();
        }

        public override Content Clone()
        {
            Post n = new Post();
            n.Title = this.Title;
            n.Body = this.Body;
            return n;
        }

        protected override string GetPrintableBody()
        {
            return Body;
        }

        protected override string GetPrintableTitle()
        {
            return Title;
        }
    }
}
