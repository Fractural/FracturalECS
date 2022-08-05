using Godot;

namespace Fractural.ECS
{
	public class ECSManager : Node
	{
		public override void _Ready()
		{
			var contexts = Contexts.sharedInstance;
			var e = contexts.game.CreateEntity();
			e.AddHealth(100);

			GD.Print("e.health.value: " + e.health.value);
		}
	}
}