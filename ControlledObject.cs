using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlledObjects
{
    public class ControlledObject : IControlledObject
    {
        public event Action<IControlledObject> OnCreate;
        public event Action<IControlledObject> OnDestroy;
    }
}
