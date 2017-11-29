using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Dept
    {
        public Dept()
        {
            CreateDate = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display (Name = "Dept Name")]
        [Required]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}