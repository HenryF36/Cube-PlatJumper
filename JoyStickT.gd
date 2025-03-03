extends Node

func _ready() -> void:
	print("Conected Joypads: ", Input.get_connected_joypads())
