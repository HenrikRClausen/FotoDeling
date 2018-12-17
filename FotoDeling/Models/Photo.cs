using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FotoDeling.Models {
    public class Photo {
        public DbSet Photos;

        public int PhotoID { get; set; }

        [Required]
        public string Title { get; set; }

        [DisplayName("Picture")]
        public byte[] PhotoFile { get; set; }

        public string ImageMimeType { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Billede oprettet")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CreatedDate { get; set; }

        public string UserName { get; set; }

        public virtual List<Comment> Comments { get; set; }
        }
    }