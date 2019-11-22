using System;

using R5T.Guide;


namespace R5T.Corcyra
{
    public class CatchmentIdentity : TypedGuid
    {
        #region Static

        public static CatchmentIdentity New()
        {
            var geographyIdentity = new CatchmentIdentity();
            return geographyIdentity;
        }

        public static CatchmentIdentity From(Guid value)
        {
            var geographyIdentity = new CatchmentIdentity(value);
            return geographyIdentity;
        }

        #endregion



        public CatchmentIdentity(Guid value)
            : base(value)
        {
        }

        public CatchmentIdentity()
            : this(Guid.NewGuid())
        {
        }
    }
}
