using UnityEngine;
using System.Collections;

public class scriptMoveFundo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-3, 0);

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x <= -10.55f)
		{	
			transform.position = new Vector2 (15.85f, 0);
		}

	
	}
}
