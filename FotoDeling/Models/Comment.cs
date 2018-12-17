using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FotoDeling.Models {
    public class Comment {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(250, ErrorMessage = "Skriv lidt kortere, tak. Op til 250 tegn.")]
        public string Body { get; set; }

        public virtual Photo Billede { get; set; }
        }
    }