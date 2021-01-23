
using UnityEngine;

public class Pretice : MonoBehaviour




{
    #region 練習欄位屬性，欄位
    [Header("高度"), Tooltip("這是高度int")]
    public int height = 1;

    //標題                   範圍
    [Header("重量"), Range(1, 10), Tooltip("這是重量float")]
    public float heavy = 1f;

    //懸浮提示
    [Header("品牌"),Tooltip("這是品牌 /名稱string")]
    public string sgin = "1";

    [Header("這是是否有窗bool")]
    public bool haswindows = true;

    //顏色
    public Color hascolor = Color.yellow;
    public Color hascolor1 = new Color(0, 1, 1, 1);

    //座標 向量
    public Vector2 hasposition = Vector2.zero;
    public Vector3 hasposition1 = Vector3.zero;
    public Vector4 hasposition2 = Vector4.one;
    public Vector4 hasposition3 = new Vector4(0, 0, 0, 0);

    //圖片 音效
    public Sprite picture;
    public AudioClip music;

    //遊戲物件(所有物件)
    public GameObject Object;

    //遊戲元件(任何包含此元件的物件)
    public Camera cam;
    public Transform tran;
    #endregion

    #region 練習方法

    //修飾詞    傳回類型            名稱(參數類型 參數名稱,參數類型 參數名稱......){    }
    //Public    void(無傳回)        自訂
    //private   int/float(有傳回)  如果名稱是藍色的=事件



    //無傳回方法
    public void Zero()
    {
        //輸出名稱
        print("完美");
    }

    //有傳回方法
    public int One()
    {
        return 1;
    }
    public float Two()
    {
        return 1.2f;
    }
    public string Three()
    {
        return "3";
    }

    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="Way">方向</param>
    /// <param name="Speed">速度</param>
    /// <param name="Audio">音效</param>
    //參數
    public void Drive(string Way,int Speed,string Audio)
    {
        print("開車方向=" + Way);
        print( "開車速度=" + Speed);
        print( "開車音效=" + Audio);

    }
    //有預設值得參數要放在最後面
    public void Drive_W( string Windows,int Sweep=5)
    {
        print("雨刷名稱=" + Windows);
        print("雨刷速度=" + Sweep);
    }






    //在特定時間點進行一次
    public void Start()
    {
        //使用欄位名稱
        //取得
        print("品牌:" + sgin);

        //設定
        heavy = 88f;

        
        
        
        //呼叫方法TEST，達成輸出
        Zero();

        //1.有傳回方法呼叫
        print("有傳回方法int" + One());
        print("有傳回方法float" + Two());
        //2.預設變數區塊(可放方法或事件)，把數值保留在這裡，利用變數區快執行
        string MyThree = Three();

        //參數引述
        Drive("右邊",100,"衝阿");
        Drive_W("雨刷窗", Sweep:100);
    }
    #endregion
}

