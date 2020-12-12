using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RoCoKingdom
{
    public class Game_Judge_Day : MonoBehaviour
    {
        public Image Night_Panel;//晚上的UI界面
        public Image Day_Panel;//白天的UI界面
        void Start()
        {
            // 时间 小于24      大于1 可以玩游戏
            // 时间 小于等于0 且 小于1
            if ((System.DateTime.UtcNow.Hour + 8) >= 1 && (System.DateTime.UtcNow.Hour + 8) < 24)
            {//可以玩游戏 显示登陆界面
                Day_Panel.gameObject.SetActive(true);
            }
            else
            {//不可以玩游戏 显示夜晚界面
                Night_Panel.gameObject.SetActive(true);
            }

        }

        void Update()
        {

        }
    }
}