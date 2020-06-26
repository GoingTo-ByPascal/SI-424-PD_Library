using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Locatable Locatable { get; set; }
        public int LocatableId { get; set; }
    }
}
