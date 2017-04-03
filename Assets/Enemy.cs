using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 8;
    Vector3 targetPos;
    GameObject ballObj;

	void Start () {
        
	}
	
	
	void Update () {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        targetPos = Vector3.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
        gameObject.transform.position = new Vector3(20, targetPos.y,0);
	}
}
