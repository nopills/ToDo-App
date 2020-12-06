using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models
{
    public class Board
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();
    }
}
