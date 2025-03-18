using System;

namespace Assi2
{
    //FancyPost class inherits from Post
    class FancyPost : Post
    {
        //Default cstor with parameters
        public FancyPost(string t, string b) : base(t, b) {

        }

        //Default cstor w/o parameters
        public FancyPost() : base("Downloaded Title", "Downloaded Body")
        {
        }

        //Override for GetPrintableTitle()
        public override string GetPrintableTitle()
        {
            return "??? " + Title.ToUpper() + " ???";
        }

        //Override for GetPrintableBody()
        public override string GetPrintableBody()
        {
            return "=========================================\n" +
                     Body + "\n"+
                   "=========================================";
        }
        
        //Clone implementation for FancyPost
        public override Content Clone()
        {
            FancyPost n = new FancyPost();
            n.Title = this.Title;
            n.Body = this.Body;
            return n;
        }
    }
}
