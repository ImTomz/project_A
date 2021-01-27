using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Camera playerCamera;
    public Transform player;
    public Vector3 cameraOffset;

    [Range(2,10)]
    public float smoothFactor;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 playerPosition = player.position + cameraOffset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, playerPosition, smoothFactor * Time.fixedDeltaTime);

        transform.position = smoothPosition;
    }
}
