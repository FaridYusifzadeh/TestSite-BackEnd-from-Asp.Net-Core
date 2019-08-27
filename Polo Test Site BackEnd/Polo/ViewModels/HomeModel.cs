using Polo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polo.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }

        public IEnumerable<Welcome> Welcomes { get; set; }
        public IEnumerable<WhatWeDo> WhatWeDos { get; set; }

        public IEnumerable<OurWork> OurWorks { get; set; }

    }
}
