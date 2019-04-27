using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
