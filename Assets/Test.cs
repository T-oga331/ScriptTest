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
        int[] grade = new int[5];

        // 配列の要素に値を代入
        grade[0] = 10;
        grade[1] = 11;
        grade[2] = 12;
        grade[3] = 13;
        grade[4] = 14;

        // 配列要素の数ぶんだけ繰り返し
        for (int i = 0; i < 5; i++) 
        {
            
                // 順番に表示する
                Debug.Log(grade[i]);
        }
        
        // 配列の要素の数ぶんだけ繰り返し
        for (int t = 0; t > 5; t--) 
        {
            // 逆順に表示する
            Debug.Log(grade[t]);
        }
       
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}