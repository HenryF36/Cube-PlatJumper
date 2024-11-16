using Godot;
using System;


public partial class BottomDieArea : Area3D
{
	public override void _Ready()
	{
		// Connect the body_entered signal to a function
		this.BodyEntered += OnBodyEntered;
	}

	private void OnBodyEntered(Node body)
	{
		// Check if the body that entered is the player
		if (body is Player)
		{
			// Call a function when the player collides with Object4
			GD.Print("Player collided with DieArea");
			GetTree().ChangeSceneToFile("res://Screens/Died.tscn");
			GD.Print("Scene Changed.");
		}
	}
}
