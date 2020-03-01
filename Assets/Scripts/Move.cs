using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// 移动速度
	public float speed = 5;
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		// 移动位置
		// Time.deltaTime ->  1秒50帧 1/50  -> 1M/s
		transform.Translate(new Vector3(h, v, 0) * Time.deltaTime * speed);
	}
}
