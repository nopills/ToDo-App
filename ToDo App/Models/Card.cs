using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
