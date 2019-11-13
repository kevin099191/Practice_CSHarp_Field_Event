
using UnityEngine;

public class Chikth : MonoBehaviour
{

    [Header("移動速度"),Range(0.1f,99.9f)]
    public float Speed;
    [Header("跳躍高度"), Range(0, 2000)]
    public int Hight;
    [Header("對話內容")]
    public string Talk = "咕咕咕~~~";
    [Header("是否取得雞蛋")]
    public bool egg;

    private void Start()
    {
        print("遊戲開始");
        print("咕咕咕~~~");
    }






}
