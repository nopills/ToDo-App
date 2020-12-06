using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models
{
    public class Section
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
    }
}
