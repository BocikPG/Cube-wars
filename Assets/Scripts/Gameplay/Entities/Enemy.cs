using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	//public/inspector
	[SerializeField] private float speed = 1;

	[SerializeField] private Player player;

	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private Collider2D coll;

	//Unity methods
	public void Start()
	{
        player = (Player)FindObjectOfType(typeof(Player));
	}


	public void Update()
	{
		Vector2 playerPos = player.transform.position;
		Vector2 myPos = transform.position;
		MoveTowards(((playerPos - myPos).normalized) * -1);
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag(Player.Tag))
		{
			coll.enabled = false;
			rb.Sleep();
			rb.simulated = false;
		}
	}
	//private methods
	private void MoveTowards(Vector3 destination)
	{
		//rb.AddForce(speed * Time.deltaTime * destination);
		rb.velocity = speed * destination;
		//rb.MovePosition(destination * Time.deltaTime);
		//transform.position += speed * Time.deltaTime * destination;
	}
}
