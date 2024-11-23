extends Area3D

# Exported variables with proper types
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
	print("Body Entered.")  # Debug message to confirm that collision was detected

	# Check if the body that entered is the player
	if body == Player:
		print("Player collided with P5-02-S")
		
		# Change the scene to the specified file
		get_tree().change_scene_to_file("res://Level 2/Level 2.tscn")
		
		# Print message after the scene change command is issued
		print("Scene Changed.")
		
		# Use the global variable to track unlocked levels
		if Global.LevelsUnlkd == 1:
			Global.LevelsUnlkd = 2  # Unlock the next level
			print("Next level unlocked: ", Global.LevelsUnlkd)
	else:
		print("Collision detected with an unexpected node.")
