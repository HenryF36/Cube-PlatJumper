extends Area3D

# Exported variable with proper type
@export var Player : CharacterBody3D

# Called when the node enters the scene tree for the first time.
func _ready():
	# Ensure Player is assigned in the editor
	if Player == null:
		print("Warning: Player node is not assigned!")
	else:
		# Connect the body_entered signal to the _on_body_entered function
		body_entered.connect(_on_body_entered)

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass

# Called when a body enters this Area3D
func _on_body_entered(body: Node) -> void:
	# Check if the body that entered is the player
	print("Body Entered.")
	if body == Player:
		print("Player collided with P5-02-S")
	else:
		print("Collision detected with an unexpected node.")
