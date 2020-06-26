﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library
{
    public class Locatable
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public List<Visit> Visits = new List<Visit>();
    }
}
