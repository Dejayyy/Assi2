using System;

namespace Assi2
{
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) {

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
        public override object Clone()
        {
            return new FancyPost(this.Title, this.Body);
        }
    }
}
