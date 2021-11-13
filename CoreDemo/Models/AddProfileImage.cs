using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WiterImage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string WriterPasswordAgain { get; set; }
        public bool Status { get; set; }
    }
}
