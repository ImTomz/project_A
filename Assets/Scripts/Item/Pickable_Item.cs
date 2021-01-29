using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable_Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("item picked");
            Destroy(gameObject);
        }
    }
}
