using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Camera playerCamera;
    public GameObject player;
    public float cameraOffset = -5f;

    private Vector2 playerPosition;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector2(player.transform.position.x,player.transform.position.y);
        playerCamera.transform.position = new Vector3(player.transform.position.x , player.transform.position.y, cameraOffset);
    }
}
