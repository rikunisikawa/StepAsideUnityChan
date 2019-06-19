using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    private bool isDestroy;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * カメラのｚ位置とtransform(自分自身)のz位置を比較して、もしカメラの位置よりtransformが後ろに行ったら
		Destroy(自分自身);
			Destroyしたら、isDestroyをtrueにする
			isDestroy = true;
         */
        if (isDestroy == false)
        {
            if (transform.localPosition.z < Camera.main.transform.localPosition.z)
            {
                Destroy(gameObject);
                isDestroy = true;
            }
        }
    }
}