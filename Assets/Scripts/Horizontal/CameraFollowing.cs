using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollowing : MonoBehaviour

{

    public Rigidbody2D toFollow;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(toFollow.transform.position.x, toFollow.transform.position.y, transform.position.z);
    }
}
