using System;

namespace MuiPrismNavigation.Models
{
    public abstract class AbstractCloneable : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
