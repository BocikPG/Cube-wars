using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//static
	public static readonly string Tag = "Player";

	//public/inspector

	[SerializeField] private float speed;
	[SerializeField] private Rigidbody2D rb;

	//unity methods
	void Update()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		rb.velocity = new Vector2(h * speed, v * speed);
		//rb.transform.position = new Vector2(transform.position.x + (h * speed), transform.position.y + (v * speed));
	}
}
