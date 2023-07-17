namespace controlledObjects
{
    public interface IControlledObject
    {
        public event Action<IControlledObject> OnCreate;
        public event Action<IControlledObject> OnDestroy;
        public void Create();
        public void Destroy();
        public void SetLifeTime();
    }
}