using System;

using R5T.Guide;


namespace R5T.Corcyra
{
    public class GeographyIdentity : TypedGuid
    {
        #region Static

        public static GeographyIdentity New()
        {
            var geographyIdentity = new GeographyIdentity();
            return geographyIdentity;
        }

        public static GeographyIdentity From(Guid value)
        {
            var geographyIdentity = new GeographyIdentity(value);
            return geographyIdentity;
        }

        #endregion



        public GeographyIdentity(Guid value)
            : base(value)
        {
        }

        public GeographyIdentity()
            : this(Guid.NewGuid())
        {
        }
    }
}
