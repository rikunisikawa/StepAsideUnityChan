using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private GameObject unitychan;
	private float difference;

	// Use this for initialization
	void Start () {
		this.unitychan = GameObject.Find ("unitychan");
		//カメラの位置は？
		this.difference = unitychan.transform.position.z - this.transform.position.z;
	}

	// Update is called once per frame
	void Update () {
		//y座標についての情報は？
		this.transform.position = new Vector3(0,this.transform.position.y, this.unitychan.transform.position.z-difference);
	}
}
