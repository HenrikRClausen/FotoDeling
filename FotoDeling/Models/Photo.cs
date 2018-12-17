using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FotoDeling.Models {
    public class Photo {
        public int PhotoID { get; set; }
        public string Title { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }

        virtual public List<Comment> Comments { get; set; }
        }
    }