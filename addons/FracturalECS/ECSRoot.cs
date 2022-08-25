using Godot;
using Svelto.ECS;
using Svelto.ECS.Schedulers;

namespace GodotSveltoECS
{
    public interface IProcessEngine : IStepEngine<float> { }

    public abstract class ECSEngine : Godot.Object, IEngine
    {

    }

    public class ECSRoot : Node
    {
        class ProcessEnginesGroup : UnsortedEnginesGroup<IProcessEngine, float> { }

        EnginesRoot _enginesRoot;
        ProcessEnginesGroup _processEnginesGroup;
        SimpleEntitiesSubmissionScheduler _scheduler;

        public override void _Ready()
        {
            _scheduler = new SimpleEntitiesSubmissionScheduler();
            //An EnginesRoot holds all the engines and entities created. it needs a EntitySubmissionScheduler to know when to
            //add previously built entities to the Svelto database. Using the SimpleEntitiesSubmissionScheduler
            //is expected as it gives complete control to the user about when the submission happens
            _enginesRoot = new EnginesRoot(_scheduler);

            GD.Print("ECS root initialized");
        }

        public override void _Process(float delta)
        {
            _scheduler.SubmitEntities();
            _processEnginesGroup.Step(delta);
        }

        public override void _Notification(int what)
        {
            if (what == NotificationPredelete)
            {
                _enginesRoot.Dispose();
            }
        }

        public void AddEngine<T>(T engine) where T : class, IEngine
        {
            _enginesRoot.AddEngine(engine);
            if (engine is IProcessEngine processEngine)
                _processEnginesGroup.Add(processEngine);
        }
    }
}