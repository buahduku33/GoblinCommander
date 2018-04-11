using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemy;
    public Transform[] location;
	// Use this for initialization
	void Start () {
        StartCoroutine(enemySpawner());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public IEnumerator enemySpawner()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        Instantiate(enemy,location[Random.Range(0,5)].position,Quaternion.identity);
        StartCoroutine(enemySpawner());
    }
}
