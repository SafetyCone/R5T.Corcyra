using System;

using R5T.Stagira;


namespace R5T.Corcyra
{
    public class GeoJsonMultiPolygonJsonString : TypedString
    {
        #region Static

        public static GeoJsonMultiPolygonJsonString From(string geoJsonMultiPolygonJsonStringValue)
        {
            var geoJsonMultiPolygonJsonString = new GeoJsonMultiPolygonJsonString(geoJsonMultiPolygonJsonStringValue);
            return geoJsonMultiPolygonJsonString;
        }
        
        #endregion


        public GeoJsonMultiPolygonJsonString(string value)
            : base(value)
        {
        }
    }
}
