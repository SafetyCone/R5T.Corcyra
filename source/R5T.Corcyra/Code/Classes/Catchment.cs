using System;
using System.Collections.Generic;


namespace R5T.Corcyra
{
    public class Catchment
    {
        public CatchmentIdentity Identity { get; set; }
        public string Name { get; set; }
        public List<LngLat> Boundary { get; } = new List<LngLat>();
    }
}
