using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerVertical : MonoBehaviour {
    RectTransform tf;
    Transform mainCanvas;
    Transform bg;
    public int xSpeed = 3;
    public float ySpeed = 1.5f;
    public float yCSpeed = 2f;

    // Start is called before the first frame update
    void Start() {
        tf = gameObject.GetComponent<RectTransform>();
        mainCanvas = GameObject.Find("LevelParent").transform;
        bg = GameObject.Find("bg").transform;
    }

    // Update is called once per frame
    void Update() {
        mainCanvas.position += Vector3.up * yCSpeed;
        bg.position += Vector3.up * yCSpeed / 2;

        float parallaxYSpeed = ySpeed / 2;
        if (GlobalControls.input.Up > 0) {
            mainCanvas.position += Vector3.down * ySpeed;
            bg.position += Vector3.down * ySpeed / 2;
        }
        if (GlobalControls.input.Down > 0) {
            mainCanvas.position += Vector3.up * ySpeed;
            bg.position += Vector3.up * ySpeed / 2;
        }

        if (GlobalControls.input.Left > 0)  tf.position += Vector3.left  * xSpeed;
        if (GlobalControls.input.Right > 0) tf.position += Vector3.right * xSpeed;

        Debug.Log(tf.position);

        if (tf.localPosition.x < 120) tf.localPosition = new Vector3(120, tf.localPosition.y, tf.localPosition.z);
        if (tf.localPosition.x > 520) tf.localPosition = new Vector3(520, tf.localPosition.y, tf.localPosition.z);
    }
}
