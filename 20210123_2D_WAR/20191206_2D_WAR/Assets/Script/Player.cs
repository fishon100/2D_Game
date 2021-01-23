
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 10.5f;

    //標題                   範圍
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump_H = 100;

    //bool一開始預設是false
    [Header("是否在地板上"), Tooltip("是否在地板上")]
    public bool onfloor = false;

    //懸浮提示
    [Header("子彈"), Tooltip("子彈")]
    public GameObject boom;

    [Header("子彈生成點"), Tooltip("子彈生成點")]
    public Transform pointSpawn;

    [Header("子彈速度"), Range(0, 5000)]
    public int speedBoom = 800;

    [Header("子彈攻擊力"), Range(1, 1000)]
    public float attack = 10;

    [Header("開槍音效"), Tooltip("開槍音效")]
    public AudioClip boomVoice;

    [Header("鑰匙音效")]
    public AudioClip KeySound;


    [Header("血量"), Range(0, 200)]
    public float blood = 100f;



    [Header("圖示.地面判定位移")]
    public Vector3 offset;

    [Header("圖示.地面判定半徑")]
    public float ratio = 0.3f;



    private AudioSource aud;

    private Rigidbody2D rig;

    private Animator ani;

    private Transform Tra;

    [Header("水平值")]
    //水平值
    public float H;


    private void Start()
    {
        // GetComponent<泛型>()
        // 鋼體名稱 = 取得元件<鋼體2D>();
        rig = GetComponent<Rigidbody2D>();

        //動畫名稱 = 取得元件<動畫控制器>();
        ani = GetComponent<Animator>();

        //音效名稱 = 取得元件<音效控制器>()；
        aud = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //取得水平值
        GetHorizontal();
        //呼叫Move();
        Move();
        //呼叫Jump();
        Jump();
        //呼叫Shoot();
        Shoot();


    }

    //在UNITY繪製圖示
    private void OnDrawGizmos()
    {
        //圖示.顏色
        Gizmos.color = Color.green;
        //圖示.形狀圓形(物體中心，半徑)
        Gizmos.DrawSphere(transform.position + offset, ratio);

    }

    /// <summary>
    /// 觸發事件
    /// </summary>
    /// <param name="collision">碰到的物件資訊</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果(碰到.物件標籤tag == "標籤名稱")
        if (collision.tag =="鑰匙")
        {
            //物件.銷毀(碰到.物件)
            GameObject.Destroy(collision.gameObject);

            aud.PlayOneShot(KeySound, Random.Range(1.2f, 1.5f));
        }

         
    }

    //白色名稱為須呼叫
    private void GetHorizontal()
    {
        //取得玩家操控的(水平值a/d)，右 = 1，左 = -1
        H = Input.GetAxis("Horizontal");
    }


    /// <summary>
    /// 跑步移動
    /// </summary>
    public void Move()
    {
        //鋼體.重力加速度 = 2為向量(水平值*速度，原本y的重力速度 y的)
        rig.velocity = new Vector2(H * speed, rig.velocity.y);

        //如果按下(按鍵D)或右鍵 就執行{內容}
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("按下D");

            //公用方向值，可放入有Transform的其他物件
            //私人方向值，使用跟腳本同一元件(小寫transform).Rotantion的選轉寫法localEulerAngles = 三維選轉值都為0
            transform.localEulerAngles = Vector3.zero;
        }

        //如果按下(按鍵A)或左鍵 就執行{內容}
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("按下A");

            //公用方向值，可放入有Transform的其他物件
            //私人方向值，使用跟腳本同一元件(小寫transform).Rotantion的選轉寫法localEulerAngles = 三維選轉(0，y軸180，0)
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }

        //動畫.取得設置布林值("動畫參數名稱" ，水平值!= 0)
        ani.SetBool("開始跑", H != 0);    //H 不為右1 也不為左-1 = 0

    }



    /// <summary>
    /// 跳躍
    /// </summary>
    public void Jump()
    {
        //如果 在地板上 並且 按下(space) 就執行{內容}
        if (onfloor  && Input.GetKeyDown(KeyCode.Space)) //onfloor限制跳躍
        {
            print("按下空白建");

            //缸體.添加推力(二維向(0 ，在y增加推力))
            rig.AddForce(new Vector2(0, jump_H));

            ani.SetTrigger("跳躍觸發");

        }
    
        //2D碰撞 撞到 = 2D物理.覆蓋圓形(中心點，半徑，圖層) 1<<圖層
        Collider2D hit = Physics2D.OverlapCircle(transform.position + offset, ratio, 1 << 9);


        //如果撞到地板 就設置 是否在地板上 為 true 
        if (hit)
        {
            onfloor = true;
        }
        //否則         就設置 是否在地板上 為 false 
        else
        {
            onfloor = false;
        }

        //動畫控制器.設置浮點數("參數名稱" ，原本y的重力速度 y的) 
        ani.SetFloat("開始跳 ", rig.velocity.y);
        ani.SetBool("是否在地面上", true);


    }

    /// <summary>
    /// 開槍
    /// </summary>
    public void Shoot()
    {
        
        //如果按下滑鼠左鍵/手機為觸控
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            
            //音效來源.撥放一次(開槍音效，音量隨機範圍(1.5f，2f))
            aud.PlayOneShot(boomVoice, Random.Range(1.2f, 1.5f));   
            
            //物件區域變數 名稱/暫存 = 生成(物件名稱，生成點.座標，生成點.角度)
            GameObject temp =  Instantiate(boom, pointSpawn.position, pointSpawn.rotation);

            //暫存子彈.取得元件<鋼體>().添加推力(生成點.右邊*子彈速度 + 生成點.上方 * 高度)
            temp.GetComponent<Rigidbody2D>().AddForce(pointSpawn.right * speedBoom + pointSpawn.up * 150);

            ani.SetTrigger("射擊觸發");
        }
    }


    /// <summary>
    /// 傷害
    /// </summary>
    /// <param name="getHurt">受到傷害</param>
    public void Hurt(float getHurt)
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    public void Dead()
    {

    }




}
