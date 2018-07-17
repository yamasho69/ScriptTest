using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 30;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;

        // 配列の要素をすべて表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
}

