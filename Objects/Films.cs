﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI
{
    internal class Films : StarWars
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public DateTime release_date { get; set; }
        public List<string> species { get; set; }
        public List<string> starships { get; set; }
        public List<string> vehicles { get; set; }
        public List<string> characters { get; set; }
        public List<string> planets { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }

        public Films() { }
    }
}
