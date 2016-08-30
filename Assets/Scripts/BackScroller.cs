using UnityEngine;
using System.Collections;

public class BackScroller : MonoBehaviour {
    public float scroll_speed = 1.2f;
    Material myMaterial;

	// Use this for initialization
	void Start () {
        myMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        float newOffsetY = myMaterial.mainTextureOffset.y + scroll_speed * Time.deltaTime;
        Vector2 newOffset = new Vector2(0, newOffsetY);
        myMaterial.mainTextureOffset = newOffset;
	}
}
