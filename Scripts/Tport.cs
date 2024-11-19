using Godot;
using System;

public partial class P205T : Area3D
{
	// Exported variable to assign a reference to the player
	[Export]
	public CharacterBody3D Thing;
	[Export]
	public Vector3  targetPosition;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.BodyEntered += OnBodyEntered;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void OnBodyEntered(Node body)
	{
		// Check if the body that entered is the player
		if (body is Player)
		{
			// Call a function when the player collides with Object4
			GD.Print("Player collided with Trampoline");

			// Example: You can now access the 'p' reference (player) and manipulate it
			// Set the player's GlobalTransform to the new position with the same basis (rotation and scale)
			Thing.GlobalTransform = new Transform3D(Thing.GlobalTransform.Basis, targetPosition);
		
		}
	}
}
