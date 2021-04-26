using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 要素の個数が5、各要素の値を順番と逆順に表示
        // 要素数5の配列を初期化
        int[] array = new int[5];

        // 配列の要素に値を代入
        array[0] = 808;
        array[1] = 11;
        array[2] = 345;
        array[3] = 2760;
        array[4] = 567;

        // 配列要素の数ぶんだけ繰り返し
        for (int i = 0; i < 5; i++)
        {  
            // 順番に表示する
            Debug.Log(array[i]);
        }

        // 配列の要素の数ぶんだけ繰り返し
        for (int i = 4; i >= 0; i--)
        {
            // 逆順に表示する
            Debug.Log(array[i]);
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}