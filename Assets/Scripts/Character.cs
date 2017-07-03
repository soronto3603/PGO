using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	private const int MOUSE_LEFT_KEY = 0;

	public float Speed = 10.0f;

	// Use this for initialization
	void Start ()
    {
        InputManager.MouseLock = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        var delta = InputManager.GetKeyboardMovement(Speed);
		transform.Translate(delta);

		if (Input.GetKeyDown("escape"))
		{
            InputManager.MouseLock = true;
		}
		else if (Input.GetMouseButtonDown(MOUSE_LEFT_KEY))
		{
            InputManager.MouseLock = false;
		}
	}
}
