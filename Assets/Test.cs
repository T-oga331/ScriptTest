using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 要素の個数が5、各要素の値を順番に表示
        // 要素数5の配列を初期化
        int[] grade = new int[5];

        // 順番の各要素に値を代入
        grade [0] = 10;
        grade [1] = 11;
        grade [2] = 12;
        grade [3] = 13;
        grade [4] = 14;

        // 順番に表示されるようにする
        for (int i = 0; i < 5; i++)
        {
            Debug.Log ( grade [i] );
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}