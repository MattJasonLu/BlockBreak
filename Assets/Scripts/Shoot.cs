using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	// 设置子弹的初始速度
	public float speed = 10;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			GameObject bulletGo = Instantiate(bullet, transform.position, Quaternion.identity);
			// 获取刚体组件
			Rigidbody rgd = bulletGo.GetComponent<Rigidbody>();
			rgd.velocity = transform.forward * speed;
        }
    }
}
