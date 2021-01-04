using System;
using System.Collections.Generic;


namespace R5T.Corcyra
{
    public class Catchment
    {
        public CatchmentIdentity Identity { get; set; }
        public string Name { get; set; }
        // NOTE: this approach to boundary is simplified! Anything with multiple
        // "chunks" or holes will not be represented correctly
        public List<LngLat> Boundary { get; } = new List<LngLat>();
    }
}
