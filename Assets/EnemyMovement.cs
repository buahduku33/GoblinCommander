using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject target;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Capsule");
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = target.transform.position - transform.position;
        rb.velocity = new Vector3(1f * direction.x, 0f, 1f * direction.z);
	}
}
