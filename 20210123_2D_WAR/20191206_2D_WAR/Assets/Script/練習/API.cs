
using UnityEngine;

public class API : MonoBehaviour
{
    //非靜態屬性

    //取得  
    //語法:  
    //修飾詞 類別 名稱;
    //欄位名稱.非靜態屬性;

    //設定  
    //語法:  
    //修飾詞 類別 名稱;
    //欄位名稱.非靜態屬性 指定=  值;

    //屬性 取得
    public Transform tra;

    //屬性 設定
    public Transform tra1;

    //攝相機 非靜態屬性
    public Camera cam;




    //非靜態方法

    //使用
    //語法:
    //修飾詞 類別 名稱;
    //欄位名稱.非靜態方法(值);

    //方法 使用
    public Transform tra2;


    private void Start()
    {
        //取得
        print("座標"+tra.position);

        //設定
         tra1.position =new Vector3 (3, 5, 9);
        tra1.Translate(Vector3.up * Time.deltaTime, Space.World);

        //攝相機 靜態屬性
        print("攝相機:" + Camera.allCamerasCount);
        //攝相機 非靜態屬性
        cam.backgroundColor = new Color(1, 2, 3);
    }

    private void Update()
    {
        //使用
        tra2.Rotate(9f, 11.5f, 7.8f);
    }
}
