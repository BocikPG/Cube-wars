using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	//public/inspector
	[SerializeField] private float speed = 1;

	[SerializeField] private Player player;

	//Unity methods
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
			speed = 0;
		}
	}
    //private methods
	private void MoveTowards(Vector3 destination)
	{
		transform.position += speed * Time.deltaTime * destination;
	}
}
