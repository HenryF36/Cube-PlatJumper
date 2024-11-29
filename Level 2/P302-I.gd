extends Node

@export var Player: CharacterBody3D 
@export var P301I: Area3D

func _ready() -> void:
	if Player == null or P301I == null:
		print("Player or P301I is not assigned. Please check the exported variables.")

# Called when a body enters the area.
func _on_area_entered(body: Node) -> void:
	if body == Player:
		print("Player collided with P3-01-I.")
	else:
		print("Collision detected with an unexpected node.")
