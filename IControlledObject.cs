namespace controlledObjects
{
    public interface IControlledObject
    {
        public event Action<IControlledObject> OnCreate;
        public event Action<IControlledObject> OnDestroy;
    }
}