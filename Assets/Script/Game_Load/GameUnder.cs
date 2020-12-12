using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnder : MonoBehaviour
{
    public static GameUnder gameUnder;
    
    public string Name;//名字
    public string Coin;//洛克贝
    public string GoldCoin;//洛克钻
    public bool isLogin;//是否注册
    public int VIP = 0;//VIP等级
    public bool gender;//玩家性别 true=男 false=女
    public string Birthday;

    private void Awake()
    {
        gameUnder = this;
    }
}
