using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject item;
    private Transform playerTransform;



    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(playerTransform.position.x + 2, playerTransform.position.y);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
