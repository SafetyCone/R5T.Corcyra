using System;

using R5T.Guide;


namespace R5T.Corcyra
{
    public class LocationIdentity : TypedGuid
    {
        #region Static

        public static LocationIdentity New()
        {
            var locationIdentity = new LocationIdentity();
            return locationIdentity;
        }

        public static LocationIdentity From(Guid guid)
        {
            var locationIdentity = new LocationIdentity(guid);
            return locationIdentity;
        }

        #endregion


        public LocationIdentity(Guid value)
            : base(value)
        {
        }

        public LocationIdentity()
            : this(TypedGuid.GetNewGuid())
        {
        }
    }
}
