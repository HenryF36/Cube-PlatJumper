using Godot;
using System;

public partial class MenuButtons : Control
{
	void _on_level_select_pressed(){
		GD.Print("Level Select Button Pressed.");
		GetTree().ChangeSceneToFile("res://Menu/Level Select.tscn");
			GD.Print("Scene Changed.");
	}
	
	
}
