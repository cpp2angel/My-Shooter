using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float moveSpeed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}

	void MoveControl ()
    {
        float yMove = moveSpeed * Time.deltaTime;
        transform.Translate(0.0f, -yMove, 0.0f);
    }

	// Update is called once per frame
	void Update () {
        MoveControl();

    }
}
