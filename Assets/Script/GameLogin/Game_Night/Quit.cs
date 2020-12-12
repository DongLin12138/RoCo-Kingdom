using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    // 游戏开始 最先运行 但只执行一次
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Game_Quit);
    }

    public void Game_Quit()
    {
        Application.Quit();
        Debug.Log("游戏已退出");
    }

// 游戏更新 以帧 更新游戏
    void Update()
    {

    }
}
