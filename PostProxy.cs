using System;

namespace Assi2
{
    class PostProxy : Content
    {
        private Post _realPost;
        private bool _isDownloaded;

        public PostProxy()
        {
            _isDownloaded = false;
            _realPost = null;
        }

        public void Download()
        {
            if (!_isDownloaded)
            {
                _realPost = new FancyPost();
                _isDownloaded = true;
            }
        }

        public bool IsDownloaded()
        {
            return _isDownloaded;
        }

        public void CreateNewPost(Post prototype)
        {
            _realPost = (Post)prototype.Clone();
            _isDownloaded = true; 
        }

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

        public void SetBody(string body)
        {
            if (!_isDownloaded)
            {
                Console.WriteLine("Error: Post not downloaded yet!");
                return;
            }

            if (_realPost != null)
            {
                _realPost.Body = body;
            }
        }

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

        protected override string GetPrintableBody()
        {
            if (!_isDownloaded)
            {
                return "[Post not downloaded yet]";
            }
            if (_realPost != null)
            {
                return _realPost.Body;
            }
            return "Unable to access post body";

        }

        protected override string GetPrintableTitle()
        {
            if (!_isDownloaded)
            {
                return "[Post not downloaded yet]";
            }
            if (_realPost != null)
            {
                return _realPost.Title;
            }
            return "Unable to access post title";
        }
    }
}
