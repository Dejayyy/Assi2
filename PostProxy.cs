using System;

namespace Assi2
{
    //PostProxy class inherits from Content
    class PostProxy : Content
    {
        //Private members
        private Post _realPost;
        private bool _isDownloaded;

        //Default cstor w/o parameters
        public PostProxy()
        {
            _isDownloaded = false;
            _realPost = null;
        }

        //Method to download a post and sets _realPost to FancyPost
        public void Download()
        {
            if (!_isDownloaded)
            {
                _realPost = new FancyPost();
                _isDownloaded = true;
            }
        }
        
        //Bool check
        public bool IsDownloaded()
        {
            return _isDownloaded;
        }

        //Method to create a new post by using Clone()
        public void CreateNewPost(Post prototype)
        {
            _realPost = (Post)prototype.Clone();
            _isDownloaded = true; 
        }

        //Method to set the title
        public void SetTitle(string title)
        {
            if (!_isDownloaded)
            {
                Console.WriteLine("Error: Post not downloaded yet!");
                return;
            }

            if (_realPost != null)
            {
                _realPost.Title = title;
            }
        }

        //Method to set the body
        public void SetBody(string body)
        {
            if (!_isDownloaded)
            {
                Console.WriteLine("Error: Post not downloaded yet!"); ;
                return;
            }

            if (_realPost != null)
            {
                _realPost.Body = body;
            }
        }

        //Clone implementation for PostProxy
        public override Content Clone()
        {
            PostProxy newProxy = new PostProxy();
            if (_isDownloaded && _realPost != null)
            {
                newProxy._realPost = (Post)_realPost.Clone();
                newProxy._isDownloaded = true;
            }
            return newProxy;
        }

        //Override for GetPrintableBody()
        public override string GetPrintableBody()
        {
            if (!_isDownloaded)
            {
                return "Loading...";
            }
            if (_realPost != null)
            {
                return $"{_realPost.GetPrintableBody()}";
            }
            return "Unable to access post body";

        }

        //Override for GetPrintableTitle()
        public override string GetPrintableTitle()
        {
            if (!_isDownloaded)
            {
                return "Loading...";
            }
            if (_realPost != null)
            {
                return $"{_realPost.GetPrintableTitle()}";
            }
            return "Unable to access post title";
        }
    }
}
        