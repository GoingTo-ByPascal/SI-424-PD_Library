using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public Locatable Locatable { get; set; }
        public int LocatableId { get; set; }
    }
}
