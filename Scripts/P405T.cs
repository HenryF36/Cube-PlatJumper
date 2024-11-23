using Godot;
using System;

public partial class P405T : Area3D
{
	// Exported variables for references
	[Export]
	public CharacterBody3D Subj;
	[Export]
	public Marker3D Destination;
	[Export]
	public StaticBody3D P301;
	[Export]
	public Area3D P203D;
	[Export]
	public Area3D NOTADDEDYET;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Connect signal for body entered
		BodyEntered += OnBodyEntered;
	}

	// Called when a body enters this Area3D
	private void OnBodyEntered(Node body)
	{
		// Check if the body that entered is the player
		if (body == Subj && Subj != null && Destination != null)
		{
			GD.Print("Player collided with P4-05-T");

			// Update Subj's GlobalTransform to match Destination's position
			Subj.GlobalTransform = new Transform3D(Subj.GlobalTransform.Basis, Destination.GlobalTransform.Origin);

			// Hide and disable collisions for P301 and P203D
			P301.Visible = false;
			P203D.Visible = false;
			P301.SetDeferred("collision_layer", 0);
			P203D.SetDeferred("collision_layer", 0);
		}
		else
		{
			GD.Print("Collision detected with an unexpected node or Subj/Destination is not assigned.");
		}
	}
}
