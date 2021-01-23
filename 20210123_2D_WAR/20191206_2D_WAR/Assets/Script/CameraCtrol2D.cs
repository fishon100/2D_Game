using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrol2D : MonoBehaviour
{
    [Header("追蹤物件")]
    public Transform Target;

    [Header("追蹤速度"), Range(0, 100)]
    public float   Speed = 3.5f;


    

    /// <summary>
    /// 追蹤
    /// </summary>
    private void Track()
    {
        Vector3 PosA = Target.position;     //取得玩家座標
        Vector3 PosB = transform.position;  //取得攝相機座標 transform(小寫)使用跟腳本同一元件
        PosA.z = -10;                       //攝相機 z軸改為-10

        PosB = Vector3.Lerp(PosB, PosA, 0.5f * Speed * Time.deltaTime);   //攝相機差值  //Time.deltaTime 一偵的時間
        transform.position = PosB;                                        //更新攝相機座標
    }

    private void LateUpdate()              //在Update執行完後，執行 適用追蹤系統
    {
        Track();
    }

}
