namespace controlledObjects
{
    public class ControlledObjectFactory : Factory
    {
        private Pool<IControlledObject> pool;

        public ControlledObjectFactory()
        {
            pool = new Pool<IControlledObject>();
        }

        public override IControlledObject CreateControlledObject()
        {
            IControlledObject controlledObject = pool.GetObject();
            if (controlledObject != null)
            {
                return controlledObject;
            }
            controlledObject = new ControlledObject();
            controlledObject.SetLifeTime();
            controlledObject.OnCreate += HandleCreateObject;
            controlledObject.OnDestroy += HandleDeleteObject;
            controlledObject.Create();
            return controlledObject;
        }

        private void HandleDeleteObject(IControlledObject obj)
        {
            pool.PushObject(obj);
            Console.WriteLine("Object delete: " + obj.ToString());
        }

        private void HandleCreateObject(IControlledObject obj)
        {
            Console.WriteLine("Object created: " + obj.ToString());
        }
    }
}
