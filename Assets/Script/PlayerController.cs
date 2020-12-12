using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour
{
    public GameLoad GameLoad;//加载
    public GameUnder GameUnder;//数据
    public GameObject WrapPanel;//背包界面
    public GameObject AlertWindow;//输入信息界面
    #region 背包数据
    public Text MyInfoName;
    public Text MyInfoCoin;
    public Text MyInfoGoldCoin;
    public Text MyInfoVIP;
    #endregion

    private void Start()
    {
        GameLoad.LoadGame();
        if (GameUnder.gameUnder.isLogin)
        {
            //MyInfoName.text = GameUnder.gameUnder.Name;
            AlertWindow.SetActive(false);
            return;
        }
        AlertWindow.SetActive(true);
    }
    private void Awake()
    {
        GameLoad.LoadGame();   
    }
    private void Update()
    {
        MyInfoCoin.text = GameUnder.Coin;
        MyInfoGoldCoin.text = GameUnder.GoldCoin;
        VIPcolor();//显示颜色
    }

    void VIPcolor()//VIP颜色
    {
        if (GameUnder.VIP == 0)
        {
            MyInfoVIP.text = "<color=#c0c0c0ff>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
        else if (GameUnder.VIP <=2)
        {
            MyInfoVIP.text = "<color=#add8e6ff>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
        else if (GameUnder.VIP <= 4)
        {
            MyInfoVIP.text = "<color=#FF00FA>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
        else if (GameUnder.VIP == 5)
        {
            MyInfoVIP.text = "<color=000000>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
    }

}
