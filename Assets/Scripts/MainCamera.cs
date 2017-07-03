using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
	private Vector2 mouseLook;
	private Vector2 smooth;
	private GameObject character;

	public float Sensitivity = 5.0f;
	public float Smoothing = 2.0f;

	// Use this for initialization
	void Start ()
    {
		character = transform.parent.gameObject; // Capsule
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (InputManager.MouseLock)
		{
            var delta = InputManager.GetMouseMovement();

			delta.Scale(new Vector2(Sensitivity * Smoothing, Sensitivity * Smoothing));

			smooth.x = Mathf.Lerp(smooth.x, delta.x, 1.0f / Smoothing);
			smooth.y = Mathf.Lerp(smooth.y, delta.y, 1.0f / Smoothing);

			mouseLook += smooth;
			mouseLook.y = Mathf.Clamp(mouseLook.y, -90.0f, 90.0f);

            // X축을 기준으로 
			transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);

			character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Vector3.up);
		}
	}
}
