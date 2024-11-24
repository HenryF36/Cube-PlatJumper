extends Node
@export var Player : CharacterBody3D

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	if Player.global_transform.origin.y < -30:
		print("Player collided with Bottom.")
		# Change the scene to the specified file
		get_tree().change_scene_to_file("res://Menu/Died.tscn")
	
