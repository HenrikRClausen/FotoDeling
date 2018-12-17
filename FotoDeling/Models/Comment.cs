using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FotoDeling.Models {
    public class Comment {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        virtual public Photo Billede { get; set; }
        }
    }