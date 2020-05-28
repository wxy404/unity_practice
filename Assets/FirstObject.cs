using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ロゴを表示
        Debug.Log("スクリプトが呼び出されました！");
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.gameObject.GetComponent<Transform>();

        Vector3 worldPos = myTransform.position;
        worldPos.x = 1.0f;
        worldPos.y = 1.0f;
        worldPos.z = 1.0f;
        myTransform.position = worldPos;
    }
}
