using System;

namespace Assi2
{
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) {

        }

        public FancyPost() : base("Default Title", "Default Body")
        {
        }

        protected override string GetPrintableTitle()
        {
            return "\u2605\u2605\u2605 " + Title.ToUpper() + " \u2605\u2605\u2605";
        }
        protected override string GetPrintableBody()
        {
            return "=========================================\n" +
                   "|| " + Body + "||\n" +
                   "=========================================";
        }
        public override Content Clone()
        {
            FancyPost n = new FancyPost();
            n.Title = this.Title;
            n.Body = this.Body;
            return n;
        }
    }
}
