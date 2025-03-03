extends Node

@export var Player: CharacterBody3D 
@export var P301I: StaticBody3D
@export var P302S: Area3D
@export var P30301D: Area3D
@export var P30302D: Area3D

func _ready() -> void:
	if Player == null or P301I == null:
		print("Player or P301I is not assigned. Please check the exported variables.")
	else:
		print("P3-02-S Good.")

# Called when a body enters the area.
func _on_area_entered(body: Node) -> void:
	if body == Player:
		print("Player collided with P3-02.")
		P301I.visible = true
		P302S.visible = false
		P30301D.visible = true
		P30302D.visible = true
	else:
		print("Collision detected with an unexpected node." )
