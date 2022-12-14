using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    [SerializeField] private Player player;

    
    void Update()
    {
        Vector2 playerPos = player.transform.position;
        Vector2 myPos = transform.position;
        MoveTowards(((playerPos-myPos).normalized)*-1);
    }

    private void MoveTowards(Vector3 destination)
	{
		transform.position += speed * Time.deltaTime * destination;
    }
}
