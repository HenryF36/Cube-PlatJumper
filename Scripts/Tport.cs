using Godot;
using System;

public partial class Tport : Area3D
{
	// Exported variable to assign a reference to the player
	[Export]
	public CharacterBody3D Thing;
	[Export]
	//public Vector3  targetPosition;
	public Marker3D Destination;
	[Export]
	public string Name;

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
		if (body is Player && Thing != null && Destination != null)
		{
			GD.Print("Player collided with " + Name);

			// Update Thing's GlobalTransform to the Destination's Origin
			Thing.GlobalTransform = new Transform3D(Thing.GlobalTransform.Basis, Destination.GlobalTransform.Origin);
		}
		else
		{
			GD.Print("Collision detected with an unexpected node or Thing/Destination is not assigned.");
		}
	}
}
