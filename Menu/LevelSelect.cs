using Godot;
using System;

public partial class LevelSelect : Control
{
	private Label _label;
	private static int LevelsUnlkd = 1;

	private void _on_l_1_pressed()
	{
		GD.Print("Level One Selected.");
		GetTree().ChangeSceneToFile("res://Level 1/Level 1.tscn");
		GD.Print("Scene Changed.");
	}
	

	public override void _Ready()
	{
		
		_label = GetNode<Label>("LevelsUnlLabel");
		_label.Text = "Levels Unlocked: "+ LevelsUnlkd;
		// TODO: This program has the levels unlocked thing, store it in a file latter so It will stay the same evry time it runs. Now it is using a static var.

	}
	
}
