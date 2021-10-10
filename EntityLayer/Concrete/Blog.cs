using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }//Bloğun küçük resmi
        public string BlogImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool BlogStatus { get; set; }
        // Tablolar arası ikişki
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }

        public List<Comment> Comments { get; set; }


    }
}
