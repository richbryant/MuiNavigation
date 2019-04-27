using System;

namespace MuiNavigationService.Models
{
    public abstract class AbstractCloneable : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
