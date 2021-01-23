using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APImath : MonoBehaviour
{
    //程式運算

    //運算子
    public int a = 10, b = 3;


    private void Start()
    {
        // 數學運算子
        print(a + b);   // 加 13
        print(a - b);   // 減 7
        print(a * b);   // 乘 30
        print(a / b);   // 除 3
        print(a % b);   // 餘 10 / 3 = 3...1

        // 遞增 ++、遞減 --
        print(a++);     // 先輸出再執行遞增，a+1....
        print(a--);     // 先輸出再執行遞增，a-1....
        print(++b);     // 先執行遞增再輸出  1+b....
        print(--b);     // 先執行遞增再輸出  1-b....

        // 指定運算：等號右邊會先運算再傳給左邊
        // = 指定
        // 適用所有數學運算
        //score = score + 10;
        //score += 10;





        //比較運算值
        print(a > b);     // 大於
        print(a < b);     // 小於
        print(a >= b);    // 大於等於
        print(a <= b);    // 小於等於
        print(a == b);    // 等於
        print(a != b);    // 不等






        // 邏輯運算子
        // 並且 && shift + 7
        // 只要有一個 false 結果為 false
        print(true && true);    // t
        print(true && false);   // f
        print(false && true);   // f
        print(false && false);  // f

        // 或者 || shift + 鎮
        // 只要有一個 true 結果為 true
        //print(boolA || boolB);
        print(true || true);    // t
        print(true || false);   // t
        print(false || true);   // t
        print(false || false);  // f

        // 相反 !
        // 將布林值改為相反
        print(!true);     // false
        print(!false);    // true 
    }
}

