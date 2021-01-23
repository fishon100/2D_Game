using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    /// <summary>
    /// 認識API 靜態Static
    /// </summary>

    

    private void Start()
    {
        #region 靜態屬性存取Porperties
        //屬性
        //取得 靜態屬性
        //語法:類別名稱.靜態屬性;
        print("隨機" + Random.value);
        print("數學.拍" + Mathf.PI);

        
        //設定 靜態屬性
        //語法:類別名稱.靜態屬性 = 指定值;
        Cursor.visible = false;//鼠標.可見性 = 不可見
        Time.timeScale = 2;//時間.速度 = 2倍速
                           //Time.deltaTime = 1.5f; 唯讀Only Read  不可設值 
        #endregion



        #region 靜態方法存取Methods
        //方法
        //使用 靜態方法
        //語法:類別名稱.靜態方法(引述值)
        Random.Range(-10.0f, 10.0f);//取得範圍
        Random.Range(-10, 10);

        int number = (Mathf.Abs(-99));//取得整數
        print("整數值" + number);
        #endregion

        #region 練習
        int count = Camera.allCamerasCount;//屬性
        print("所有攝影機數量" + count);

        print("2D 的重力大小" + Physics2D.gravity);//屬性
         Physics2D.gravity= new Vector2(0, 20);//屬性

        Application.OpenURL("https://docs.unity3d.com/ScriptReference/Application.OpenURL.html");//方法

        float number9 = (Mathf.Floor(9.999f));//方法
        print("對 9.999 去小數點" + number9);

        print("取得兩點的距離" + Vector3.Distance(new Vector3(1, 1, 1),new Vector3(22, 22, 22)));//方法
         #endregion





    }

    //一秒執行約60次針數，FPS60
    private void Update()
    {
        #region 練習
        print("是否輸入任意鍵" + Input.anyKey);//屬性
        print("是否按下按鍵 (指定為空白鍵)" + Input.GetKeyDown("space"));//方法

        print("遊戲經過時間" + Time.time);//屬性
        #endregion
    }
}
