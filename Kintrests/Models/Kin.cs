using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kintrests.Models
{
    public class Kin
    {
        public int Id { get; set; }
        public string Body { get; set; }
        [Required]
        public string ImgURL { get; set; }
        [Required]
        public string LinkURL { get; set; }

        [Required]
        public virtual KintrestUser Owner { get; set; }
    }


    public class KinVM
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string ImgURL { get; set; }
        public string LinkURL { get; set; }
        public string OwnerHandle { get; set; }
    }
}