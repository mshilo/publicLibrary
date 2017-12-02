using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicLibrary
{
    public class Item : BaseItem
    {
        public int Count { get; set; }
        public int AllowedLendDays { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }

        public Item () { }
    }
}
