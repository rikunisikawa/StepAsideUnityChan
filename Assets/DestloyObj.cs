using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestloyObj : MonoBehaviour {
	
	public GameObject CarPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;

	private bool isDestroy;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Camera.main.transform.localPosition);
		if(isDestroy == false)
		{
			if (CarPrefab.transform.position.z - Camera.main.transform.localPosition.z < 0) {
				Destroy (gameObject);
				isDestroy = true;
			}
			if (coinPrefab.transform.position.z - Camera.main.transform.localPosition.z < 0) {
				Destroy (gameObject);
				isDestroy = true;
			}
			if (conePrefab.transform.position.z - Camera.main.transform.localPosition.z < 0) {
				Destroy (gameObject);
				isDestroy = true;
			}
	    }
    }
}
//DestroyObj.cs

//private bool isDestroy;

//void Update()
//{
//	if(isDestroy == false)
//	{
		//---
//		if(カメラのｚ位置とtransformのz位置を比較して、もしカメラの位置よりtransformが後ろに行ったら）
//			Destroy(gameObject);
			//Destroyしたら、isDestroyをtrueにする
//			isDestroy = true;
//			---
//			}
//			}