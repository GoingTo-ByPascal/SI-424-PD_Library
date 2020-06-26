using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library
{
    class Country
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public Locatable Locatable { get; set; }
        public int LocatableId { get; set; }
    }
}
