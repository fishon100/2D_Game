
using UnityEngine;

public class APIpretice : MonoBehaviour
{
    [Header("圖片顏色")]
    public SpriteRenderer col;
    

    [Header("物件Layer")]
    public GameObject gam;

    [Header("往右移動物件每秒0.5")]
    public Transform tra;


    private void Start()
    {
        print("圖片顏色" + col.color);
        //col.color = new Color(33, 2, 1);
        //圖片翻轉
        col.flipX = true ;

        print("物件Layer" + gam.layer);
        //物件圖層改到5(UI)
        gam.layer = 5;
    }

    private void Update()
    {
        //以世界方向往右走
        tra.Translate (0.5f, 0, 0, Space.World);
        //以自身方向往左走
        tra.Translate(-0.5f, 0, 0, Space.Self);
    }
}
