using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("鑰匙")]
    public GameObject Key;

    [Header("開門音效")]
    public AudioClip DoorSound;

    private Animator Ani;
    private AudioSource Music;

    private void Start()
    {
        Ani = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果(進入碰裝範圍.碰撞物件名稱 == "玩家" 並且 鑰匙 == 已被吃掉/已空
        if (collision.name == "玩家" && Key == null)
        {
            Ani.SetTrigger("開門");
            Music.PlayOneShot(DoorSound, Random.Range(1.2f, 1.5f));
        }
    }
}
