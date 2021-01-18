using System;


namespace R5T.Corcyra
{
    public class CatchmentGeoJson
    {
        public CatchmentIdentity Identity { get; set; }
        public string Name { get; set; }
        public GeoJsonMultiPolygonJsonString MultiPolygonGeoJsonText { get; set; }
    }
}
