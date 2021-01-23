using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //引用場景 API

//C#:繼承
//等於擁有此物件的成員  ex.MonoBehaviour.Invok
public class SenceCtrol : MonoBehaviour
{
    [Header("聲音播放器")]
    public AudioSource sou;
    [Header("音樂音效")]
    public AudioClip clip;

    [Header("背景聲音播放器")]
    public AudioSource backsou;
    



    //要設為public公開為可以使用
    public void StartGame()
    {
        backsou.Stop();
        //欄位名稱.播放一次(欄位音樂音效名稱,音量)
        sou.PlayOneShot(clip, 5);

        //延遲呼叫("需要延遲的方法名稱"，延遲時間)
        Invoke("DelayStartGame", 2.5f);
        
    }
    private void DelayStartGame()
    {
        //場景管理器.載入場景("場景名稱");
        SceneManager.LoadScene("遊玩面");
    }



    public void BacktoMenu()
    {
        //欄位名稱.播放一次(欄位音樂音效名稱,音量)
        sou.PlayOneShot(clip, 5);

        //延遲呼叫("需要延遲的方法名稱"，延遲時間)
        Invoke("DelayStartGame", 2.5f);
    }
    private void DelayBacktoMenu()
    {
        ///場景管理器.載入場景("場景名稱");
        SceneManager.LoadScene("選單");
    }




    public void QuitGame()
    {
        //欄位名稱.播放一次(欄位音樂音效名稱,音量)
        sou.PlayOneShot(clip, 5);

        //延遲呼叫("需要延遲的方法名稱"，延遲時間)
        Invoke("DelayStartGame", 2.5f);
    }
    private void DelayQuitGame()
    {
        // 應用程式.離開
        Application.Quit();
    }

}
