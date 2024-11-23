extends Control

@onready var label = $LevelsUnlLabel  # Assuming you have a Label node

# Called when the node enters the scene tree for the first time.
func _ready():
	print("Global Levels Unlocked: ", Global.LevelsUnlkd)
	label.text = "Levels Unlocked: " + str(Global.LevelsUnlkd)

# Button pressed for level 1
func _on_l_1_pressed():
	print("Level One Selected.")
	_load_level("res://Level 1/Level 1.tscn")

# Button pressed for level 2, with a check for unlocked levels
func _on_l2_pressed():
	if Global.LevelsUnlkd > 1:
		print("Level Two Selected.")
		_load_level("res://Level 2/Level 2.tscn")  # Ensure this path is correct for Level 2
	else:
		print("Level 2 not unlocked yet. Currently at Level " + str(Global.LevelsUnlkd))

# Helper function to load a level
func _load_level(level_path: String):
	var level_scene = load(level_path)
	if level_scene:
		get_tree().change_scene_to_packed(level_scene)  # Correct method for Godot 6
	else:
		print("Error loading scene: " + level_path)

#--------------------------

# Override the _input function to check for key presses
func _input(event):
	if event is InputEventKey:
		# Check if the key is pressed and it's the "V" key
		if event.pressed:
			if Input.is_key_pressed(KEY_V) and Input.is_key_pressed(KEY_CTRL) and Input.is_key_pressed(KEY_ALT):
				print("Ctrl + AltGr + V was pressed! Unlocking all levels.")
				Global.LevelsUnlkd = 10000000000
				_ready()
