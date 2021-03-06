﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FirstLogin : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject[] ColorBtn;
    public GameLoad GameLoad;
    public RandomLogin RandomLogin;//随机名字
    public InputField NameInput;
    public PlayerControl PlayerControl;
    public Text TextAlert;
    float TextAlertY;
    public bool gender;//false=男 true=女
    #region 注册
    public Text MyName;//输入框名字
    bool isRightRules;//是否勾选了公约

    private void Start()
    {
        TextAlertY = TextAlert.rectTransform.localPosition.y;
        gender = false;//默认为男
        slots[1].GetComponent<CanvasGroup>().alpha = 0.45f;//女图片暗下
    }
    public void OkClickName()//输入界面点击确定
    {
        if (!MyName.text.Equals("") && isRightRules)
        {
            GameUnder.gameUnder.Name = MyName.text;
            GameUnder.gameUnder.isLogin = true;//注册状态变为已注册
            PlayerControl.myInfoName.text = GameUnder.gameUnder.Name;//展示名字
            PlayerControl.personName.text = GameUnder.gameUnder.Name;
            PlayerControl.myInfoGoldCoin.text = GameUnder.gameUnder.GoldCoin.ToString();//展示洛克钻
            PlayerControl.myInfoCoin.text = GameUnder.gameUnder.Coin.ToString();//展示洛克贝
            PlayerControl.myInfoVIP.text = "VIP" + GameUnder.gameUnder.VIP;//展示VIP
            DateTime dt = DateTime.Now;
            GameUnder.gameUnder.Birthday = dt.ToLongDateString();
            GameLoad.SaveGame();//保存
            GameLoad.LoadGame();
            PlayerControl.AlertWindow.SetActive(false);//关闭输入信息界面
        }
        else//名字为空
        {
            TextAlert.gameObject.SetActive(true);
            TextAlert.text = "名字不能为空或先勾选条约";
        }
    }

    #endregion

    #region 技能为空提示的位置动画
    private void Update()
    {
        if (TextAlert.gameObject.activeInHierarchy)
        {
            TextAlert.rectTransform.localPosition = new Vector3(TextAlert.rectTransform.localPosition.x, TextAlert.rectTransform.localPosition.y + 3, TextAlert.rectTransform.localPosition.z);
        }
        if (TextAlert.rectTransform.localPosition.y > 120)
        {
            TextAlert.rectTransform.localPosition = new Vector3(TextAlert.rectTransform.localPosition.x, TextAlertY, TextAlert.rectTransform.localPosition.z);
            TextAlert.gameObject.SetActive(false);
        }
    }
        
#endregion
    #region 规则界面
    public Button RightRule;//勾选公约按钮
    public GameObject Rule;//公约界面

    public void RightRules()
    {
        isRightRules = !isRightRules;
        if (isRightRules)
        {
            RightRule.GetComponent<Transform>().GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            RightRule.GetComponent<Transform>().GetChild(0).gameObject.SetActive(false);
        }
    }
    public void RightR()
    {
        GameObject RulePanelBtn = Rule.GetComponent<Transform>().GetChild(2).gameObject;//获取按钮
        isRightRules = !isRightRules;
        if (isRightRules)
        {
            StartCoroutine(FlashRight(RulePanelBtn));
            RightRule.GetComponent<Transform>().GetChild(0).gameObject.SetActive(true);
        }
        else
        {
           RulePanelBtn.GetComponent<Transform>().GetChild(0).gameObject.SetActive(false);
        }
        return;
    }

    IEnumerator FlashRight(GameObject Btn)
    {
        Btn.GetComponent<Transform>().GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        Rule.SetActive(false);
    }
    #endregion
    #region 随机物 和 颜色处理
    public void RandNameClick()
    {
        if (gender == false)
        {
            int randIndex = UnityEngine.Random.Range(0, RandomLogin.boyNames.Length);
            NameInput.text = RandomLogin.boyNames[randIndex];
        }
        else if (gender == true)
        {
            int randIndex = UnityEngine.Random.Range(0, RandomLogin.girlNames.Length);
            NameInput.text = RandomLogin.girlNames[randIndex];
        }
    }
    public void RandColorClick()
    {
        int rand = UnityEngine.Random.Range(0, 7);
        RoleColor(rand);
        /*switch (rand)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
        }*/
    }

    public void RoleColor(int colorIndex)
    {//人物颜色 = 按钮颜色
        Debug.Log(ColorBtn[colorIndex].name);
    }

    #endregion
    #region 点击人物
    public void ClickBoy()
    {
        //为男时点击 不变化
        //为女时点击 变为男
        if (gender == true)
        {
            gender = false;//变为男
            slots[0].GetComponent<CanvasGroup>().alpha = 1f;//男图片高亮
            slots[1].GetComponent<CanvasGroup>().alpha = 0.45f;//女图片暗下
        }
    }
    public void ClickGirl()
    {
        //为女时点击 不变化
        //为男时点击 变为女
        if (gender == false)
        {
            gender = true;//变为女
            slots[0].GetComponent<CanvasGroup>().alpha = 0.45f;//男图片暗下
            slots[1].GetComponent<CanvasGroup>().alpha = 1f;//女图片高亮
        }
    }

    #endregion
}
