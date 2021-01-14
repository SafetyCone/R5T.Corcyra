using System;

using R5T.Stagira;


namespace R5T.Corcyra
{
    public class GeoJsonSchemaString : TypedString
    {
        #region Static

        public static GeoJsonSchemaString From(string geoJsonSchemaStringValue)
        {
            var geoJsonSchemaString = new GeoJsonSchemaString(geoJsonSchemaStringValue);
            return geoJsonSchemaString;
        }

        #endregion


        public GeoJsonSchemaString(string value)
            : base(value)
        {
        }
    }
}
