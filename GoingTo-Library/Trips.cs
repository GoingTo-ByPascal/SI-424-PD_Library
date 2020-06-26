using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace GoingTo_Library
{
    class Trips
    {
        public int Id { get; set; }
        public Locatable Locatable { get; set; }
        public int LocatableId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool State { get; set; }
    }
}
