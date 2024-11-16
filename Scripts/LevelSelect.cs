using Godot;
using System;

public partial class LevelSelect : Control
{


	private void _on_l_1_pressed()
	{
		GD.Print("Level One Selected.");
		GetTree().ChangeSceneToFile("res://Screens/Level 1.tscn");
		GD.Print("Scene Changed.");
	}

	
}
