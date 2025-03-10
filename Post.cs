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

        public override object Clone()
        {
            return new Post(this.Title, this.Body);
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
