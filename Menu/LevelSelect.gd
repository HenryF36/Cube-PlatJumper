extends Control

@onready var label = $LevelsUnlLabel  # Assuming you have a Label node

# Called when the node enters the scene tree for the first time.
func _ready():
	# Access the Global singleton and update the label with the number of unlocked levels
	label.text = "Levels Unlocked: " + str(Global.LevelsUnlkd)

func _on_l_1_pressed():
	print("Level One Selected.")
	get_tree().change_scene("res://Level 1/Level 1.tscn")

func _on_l2_pressed():
	if Global.LevelsUnlkd > 1:
		print("Level Two Selected.")
		get_tree().change_scene("res://Level 2/Level 2.tscn")
	else:
		print("Level 2 not unlocked yet. Currently at Level " + str(Global.LevelsUnlkd))

# This function could be called when a level is completed to update the unlocked levels
func _on_level_completed():
	Global.LevelsUnlkd += 1  # Increase the number of unlocked levels
	Global.save_levels()  # Save the updated unlocked levels
