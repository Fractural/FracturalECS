using Svelto.ECS;
using Fractural.ECS;
using Godot;
using System.Collections;
using Svelto.Common.Internal;

namespace Tests.MiniProject
{
    public class CompositionRoot : Node
    {
        EnginesRoot _enginesRoot;
        IEntityFactory _entityFactory;
        IEntityFunctions _entityFunctions;

        public override void _Ready()
        {
            _entityFactory = _enginesRoot.GenerateEntityFactory();
            _entityFunctions = _enginesRoot.GenerateEntityFunctions();

            _enginesRoot.AddEngine(new PlayerSpawnerEngine());
        }
    }

    public struct Transform2DComponent : IEntityComponent
    {
        Transform2D transform2D;
    }

    public struct SpriteComponent : IEntityComponent
    {
        Texture texture;
        int zIndex;
        int vframes;
        bool visible;
    }

    public class ECSGodotEntityManager
    {

    }

    public class SyncTransformEngine : IEngine, IQueryingEntitiesEngine, IProcessEngine
    {
        public SyncTransformEngine(ECSGodotEntityManager entityManager)
        {
            this.entityManager = entityManager;
        }

        public EntitiesDB entitiesDB { private get; set; }

        public string name => this.TypeName();

        readonly ECSGodotEntityManager entityManager;

        public void Ready()
        {

        }

        public void Step(in float _param)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PlayerSpawnerEngine : IEngine, IQueryingEntitiesEngine
    {
        public EntitiesDB entitiesDB { private get; set; }

        public void Ready()
        {
            SpawnPlayer();
        }

        void SpawnPlayer()
        {
            GD.Print("PlayerSpawnerEngine");
        }
    }
}