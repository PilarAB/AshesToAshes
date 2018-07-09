using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown: MonoBehaviour {

	// movement range
	public float rangeH = 0.1f;
	public float rangeV = 0;

	// speed
	public float speed = 0.1f;

	// material for dead enemies
	public Material deadMaterial;

	// direction
	int direction = 1;

	// accumulated movement
	float accMovement = 0;

	// available states
	enum State { MovingHorizontally, MovingVertically, Dead};

	// keep track of the current state
	State currState;

	// Game Manager

	// Use this for initialization
	void Start () {
		// initial state
		currState = State.MovingHorizontally;


	}

	// Update is called once per frame
	void Update () {
		// nothing happens if the enemy is dead
	
		// calculate movement  v = d / t --> d = v * t
		float movement = speed * Time.deltaTime;

		// update accumulate movement
		accMovement += movement;

		// are we moving horizontally?
		if (currState == State.MovingHorizontally)
		{
			// if yes, then transition to moving vertically
			if(accMovement >= rangeH)
			{
				// transition to moving vertically
				currState = State.MovingVertically;

				// reverse direction (for horizontal movement)
				direction *= -1;

				// reset acc movement
				accMovement = 0;
			}
			// if not, move the invader horizontally
			else
			{
				transform.position += Vector3.down * movement * direction;
			}
		}
		// this is, if we are moving vertically
		else
		{
			// if yes, then transition to moving horizontally
			if (accMovement >= rangeV)
			{
				// transition to moving horiz
				currState = State.MovingHorizontally;

				// reset acc movement
				accMovement = 0;
			}

		}
	}
		


}
