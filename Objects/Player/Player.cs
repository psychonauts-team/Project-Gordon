using Godot;

namespace ProjectGordon.Objects.Player;

public partial class Player : CharacterBody3D
{
    [Export]
    private Node3D _head;
    [Export]
    private Camera3D _camera;
    
    public override void _UnhandledInput(InputEvent @event)
    {
        
    }
}