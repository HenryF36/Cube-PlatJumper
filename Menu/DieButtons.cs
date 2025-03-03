using Godot;
using System;

public partial class DieButtons : Control
{
	void _on_menu_button_pressed(){
		GD.Print("Menu Button Pressed.");
		GetTree().ChangeSceneToFile("res://Menu/Menu.tscn");
		GD.Print("Scene Changed.");
	}
	void _on_level_select_button_pressed(){
		GD.Print("Menu Button Pressed.");
		GetTree().ChangeSceneToFile("res://Menu/Level Select.tscn");
		GD.Print("Scene Changed.");
	}
}
