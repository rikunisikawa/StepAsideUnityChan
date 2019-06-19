using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
	public GameObject carPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;
	private int startPos = -160;//intとfloatの使い方の違い
	private int goalPos = 120;
	private float posRange = 3.4f;

		

	// Use this for initialization
	void Start () {
		for (int i = startPos; i < goalPos; i += 15){//スタートとゴールのポジションの範囲で計算している
			int num = Random.Range (1, 11);//1~11?
			if (num <= 2) {
				for (float j = -1; j <= 1; j += 0.4f) { //なんでこの式？
					GameObject come = Instantiate (conePrefab) as GameObject;//コーンの式　
					conePrefab.transform.position = new Vector3 (4 * j, conePrefab.transform.position.y, i);//1直線に並べる
				}
			} else {
				for (int j = -1; j <= 1; j++) {
					int item = Random.Range (1,11);
					int offsetZ = Random.Range(-5, 6);
					if (1 <= item && item <= 6) {
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);//coinprefabではなくて？
					} else if (7 <= item && item <= 9) {
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);//carprefabではなくて？
					}
				}
			}
	}
	}
	
	// Update is called once per frame
	void Update () {
	}
}

//Start関数の意味がわからん
