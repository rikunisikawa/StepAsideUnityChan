using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {
	
	public GameObject CarPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;

	private bool isDestroy;

	// Use this for initialization
	void Start () {
		GameObject car = Instantiate (CarPrefab) as GameObject;//carPrefabの数値を使えるようにするもの
		GameObject coin = Instantiate (coinPrefab) as GameObject;//coinPrefabの数値を使えるようにするもの
		GameObject cone = Instantiate (conePrefab) as GameObject;//coneprefabの数値を使えるようにするもの
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (Camera.main.transform.localPosition);
		if(isDestroy == false)
		{
			if (CarPrefab.transform.position.z < Camera.main.transform.localPosition.z) {
				GameObject carDes = Instantiate (CarPrefab);
				Destroy (carDes);
				isDestroy = true;
			}
			if (coinPrefab.transform.position.z < Camera.main.transform.localPosition.z) {
				GameObject coinDes = Instantiate (coinPrefab);
				Destroy (coinDes);
				isDestroy = true;
			}
			if (conePrefab.transform.position.z < Camera.main.transform.localPosition.z) {
				GameObject coneDes = Instantiate (conePrefab);
				Destroy (coneDes);
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