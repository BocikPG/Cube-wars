using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//static
	public static readonly string Tag = "Player";

	//public/inspector

	[SerializeField] private float speed;

	//unity methods
	void Update()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		transform.position = new Vector2(transform.position.x + (h * speed), transform.position.y + (v * speed));
	}
}
