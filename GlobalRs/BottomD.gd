extends Node

@export var Player: CharacterBody3D

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	if Player == null:
		print("Warning: Player is not assigned!")

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	if Player and Player.global_transform.origin.y < -30:
		print("Player collided with the bottom.")
		# Change the scene to the specified file
		get_tree().change_scene_to_file("res://Menu/Died.tscn")
