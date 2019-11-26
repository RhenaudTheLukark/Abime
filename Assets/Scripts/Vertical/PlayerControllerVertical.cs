using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerVertical : MonoBehaviour {
    Transform tf;
    public int speed = 3;

    // Start is called before the first frame update
    void Start() {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        if (GlobalControls.input.Left > 0)  tf.position += Vector3.left  * speed;
        if (GlobalControls.input.Right > 0) tf.position += Vector3.right * speed;
        if (GlobalControls.input.Up > 0)    tf.position += Vector3.up    * speed;
        if (GlobalControls.input.Down > 0)  tf.position += Vector3.down  * speed;
    }
}
