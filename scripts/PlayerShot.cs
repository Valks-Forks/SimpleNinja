using Godot;
using System;

public partial class PlayerShot : AnimatableBody2D
{
  public float Speed = 300.0f;

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta)
  {
  }

  public override void _PhysicsProcess(double delta)
  {
    base._PhysicsProcess(delta);

    MoveAndCollide(new Vector2((float)(Speed * delta), 0));
  }
}
