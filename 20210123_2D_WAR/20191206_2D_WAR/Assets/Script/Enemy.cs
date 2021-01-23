
using UnityEngine;

//需第一次或重新套用腳本
//要求添加元件(類型(元件)，類型(元件)，.....
[RequireComponent(typeof(AudioSource),typeof(Rigidbody2D),typeof(CapsuleCollider2D))]
public class Enemy : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 10.5f;

    [Header("攻擊範圍"), Range(1, 1000)]
    public float RangeAtk = 10.5f;

    [Header("攻擊力"), Range(1, 1000)]
    public float attack = 10;

    [Header("攻擊音效")]
    public AudioClip AtkV;

    [Header("血量"), Range(1, 1000)]
    public float hp = 2500;

    private AudioSource aud;

    private Rigidbody2D rig;

    private Animator ani;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    /// <summary>
    /// 移動
    /// </summary>
    public void Move()
    {
        


    }
    
    /// <summary>
    /// 攻擊
    /// </summary>
    public void Hit()
    {

        
    }


    /// <summary>
    /// 傷害
    /// </summary>
    /// <param name="damage">接收傷害直</param>
    public void Damage(float damage)
    {
        hp -= damage; //遞減
        ani.SetTrigger("受傷觸發");  //受傷動畫
    }

    /// <summary>
    /// 死亡
    /// </summary>
    public void Dead()
    {

    }


}
