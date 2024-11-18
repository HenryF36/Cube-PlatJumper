using Godot;
using System;

public partial class LevelSelect : Control
{
	private Label _label;

	private void _on_l_1_pressed()
	{
		GD.Print("Level One Selected.");
		GetTree().ChangeSceneToFile("res://Screens/Level 1.tscn");
		GD.Print("Scene Changed.");
	}
	

	public override void _Ready()
	{
		// Assuming the Label node is a child of the current node, you can access it using GetNode
		_label = GetNode<Label>("LevelsUnlLabel"); // Replace with the correct node path
		// Access and modify the text of the label
		GD.Print("Curently says: " + _label.Text); // To print the current text
		//_label.Text = "New Text"; // To change the text
	}
	
}
