using Godot;
public partial class Player : CharacterBody3D
{
	// How fast the player moves in meters per second.
	[Export]
	public int Speed { get; set; } = 14;

	// The downward acceleration when in the air, in meters per second squared.
	[Export]
	public int FallAcceleration { get; set; } = 75;

	// Jump force (initial velocity for the jump).
	[Export]
	public int JumpForce { get; set; } = 20;

	// Check if the player is jumping
	private bool _isJumping = false;

	private Vector3 _targetVelocity = Vector3.Zero;

	public override void _PhysicsProcess(double delta)
	{
		var direction = Vector3.Zero;

		// Handling horizontal movement
		if (Input.IsActionPressed("move_right"))
		{
			direction.X += 1.0f;
		}
		if (Input.IsActionPressed("move_left"))
		{
			direction.X -= 1.0f;
		}
		if (Input.IsActionPressed("move_backward"))
		{
			direction.Z += 1.0f;
		}
		if (Input.IsActionPressed("move_forward"))
		{
			direction.Z -= 1.0f;
		}

		if (direction != Vector3.Zero)
		{
			direction = direction.Normalized();
			GetNode<Node3D>("Pivot").Basis = Basis.LookingAt(direction);
		}

		// Ground velocity
		_targetVelocity.X = direction.X * Speed;
		_targetVelocity.Z = direction.Z * Speed;

		// Jumping and gravity logic
		if (IsOnFloor()) // If on the ground
		{
			if (_isJumping) // If the player was jumping, reset to normal state
			{
				_isJumping = false;
			}

			// Vertical velocity reset if on the ground (not jumping)
			_targetVelocity.Y = 0;

			// Check for jump input
			if (Input.IsActionJustPressed("jump")) // When the jump button is pressed
			{
				_targetVelocity.Y = JumpForce; // Apply the jump force
				_isJumping = true; // Mark that the player is jumping
			}
		}
		else // If in the air (falling)
		{
			// Apply gravity
			_targetVelocity.Y -= FallAcceleration * (float)delta;
		}

		// Moving the character
		Velocity = _targetVelocity;
		MoveAndSlide();
	}
}
