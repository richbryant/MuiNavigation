using System;

namespace Core.Models
{
    public abstract class AbstractCloneable : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
