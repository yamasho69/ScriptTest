using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            // 残りmpを5減らす
            this.mp -= 5;
            // 残りmpが5以上だった場合
            Debug.Log("魔法攻撃をした。残りＭＰは" + this.mp);
        }
        else
        {
            // 残りmpが5未満だった場合
            Debug.Log("ＭＰが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 10回処理を繰り返す
        for (int s = 0; s <= 10; s++)
        {
            // 魔法用の関数を呼び出す
            lastboss.Magic();
        }

            // 要素数5の配列を初期化する
            int[] array = new int[5];

            // 配列の各要素に値を代入する
            array[0] = 30;
            array[1] = 20;
            array[2] = 50;
            array[3] = 10;
            array[4] = 80;

            // 配列の要素をすべて表示する
            for (int i = 0; i <= 4; i++)
            {
                Debug.Log(array[i]);
            }


                // 配列の要素をすべて表示する
                for (int i = 4; i >= 0; i--)
                {
                    Debug.Log(array[i]);
                }
         
     
    }

    // Update is called once per frame
    void Update()
    {

    }
}

