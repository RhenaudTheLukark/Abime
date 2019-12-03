using UnityEngine;

public class LoopingSprite : MonoBehaviour {
    private RectTransform rect;

    public int startY = 0;
    public int loopVal = 100;

    // Start is called before the first frame update
    void Start() {
        rect = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update() {
        if (rect.position.y < startY)
            rect.position += Vector3.up * loopVal;
        if (rect.position.y > startY + loopVal)
            rect.position -= Vector3.up * loopVal;
    }
}
