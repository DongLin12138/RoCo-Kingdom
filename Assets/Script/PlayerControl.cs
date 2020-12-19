using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerControl : MonoBehaviour
{ 
    public GameLoad GameLoad;//加载
    public GameUnder GameUnder;//数据
    public GameObject WrapPanel;//背包界面
    public GameObject AlertWindow;//输入信息界面
    #region 背包数据
    public Text myInfoName;
    public Text myInfoCoin;
    public Text myInfoGoldCoin;
    public Text myInfoVIP;
    public Text personName;
    public Text birthday;
    #endregion

    private void Start()
    {
        GameLoad.LoadGame();
        myInfoName.text = GameUnder.gameUnder.Name;//展示名字
        personName.text = GameUnder.gameUnder.Name;
        birthday.text = GameUnder.Birthday;
        if (GameUnder.gameUnder.isLogin)
        {
            myInfoName.text = GameUnder.gameUnder.Name;
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
        myInfoCoin.text = GameUnder.Coin;
        myInfoGoldCoin.text = GameUnder.GoldCoin;
        VIPcolor();//显示颜色
    }

    void VIPcolor()//VIP颜色
    {
        if (GameUnder.VIP == 0)
        {
            myInfoVIP.text = "<color=#c0c0c0ff>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
        else if (GameUnder.VIP <=2)
        {
            myInfoVIP.text = "<color=#add8e6ff>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
        else if (GameUnder.VIP <= 4)
        {
            myInfoVIP.text = "<color=#FF00FA>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
        else if (GameUnder.VIP == 5)
        {
            myInfoVIP.text = "<color=#000000>" + "VIP" + GameUnder.VIP.ToString() + "</color>";
        }
    }

}
