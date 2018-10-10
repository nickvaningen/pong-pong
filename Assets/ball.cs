using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public float speed = 5f;

	// Use this for initialization
	void Start () {
       
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Goball();
        }
    }
    public void Goball()
    {
        float sx = Random.Range(2, 2) == 0 ? -1 : 1;
        float sy = Random.Range(2, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
    }
}
