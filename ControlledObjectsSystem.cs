using System.Timers;
namespace controlledObjects
{
    public class ControlledObjectsSystem
    {
        private List<ControlledObject> controlledObjects;
        private ControlledObjectFactory factory;
        private System.Timers.Timer lifeTimer;

        public ControlledObjectsSystem()
        {
            controlledObjects = new List<ControlledObject>();
            factory = new ControlledObjectFactory();

            Random r = new Random();
            int countOfObjects = r.Next(1, 10);

            for (int i = countOfObjects; i < countOfObjects; i++)
            {
                ControlledObject obj = (ControlledObject)factory.CreateControlledObject();
                controlledObjects.Add(obj);
            }

            lifeTimer = new System.Timers.Timer(1000);
            lifeTimer.Elapsed += TimerElapsed;
            lifeTimer.AutoReset = true;
            lifeTimer.Start();
        }

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            foreach (var controlledObject in controlledObjects)
            {
                if (controlledObject.LifeTime <= lifeTimer.Interval)
                {
                    controlledObject.Destroy();
                    controlledObjects.Remove(controlledObject);
                }
            }
        }
    }
}
