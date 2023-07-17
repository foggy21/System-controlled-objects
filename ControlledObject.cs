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
        public int LifeTime { get; private set; }
        public void Create()
        {
            OnCreate?.Invoke(this);
        }

        public void Destroy()
        {
            OnDestroy?.Invoke(this);
        }

        public void SetLifeTime()
        {
            Random r = new Random();
            LifeTime = r.Next(100, 1500);
        }
    }
}
