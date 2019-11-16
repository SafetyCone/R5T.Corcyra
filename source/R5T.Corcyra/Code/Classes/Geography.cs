using System;
using System.Collections.Generic;


namespace R5T.Corcyra
{
    public class Geography
    {
        public GeographyIdentity Identity { get; set; }
        public List<LngLat> Vertices { get; } = new List<LngLat>();
    }
}
