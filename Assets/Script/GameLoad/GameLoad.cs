using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameLoad : MonoBehaviour
{
    public GameUnder GameUnder;
    //
    float SystemTime;

    public void SaveGame()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/LuokeData"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/LuokeData");
            return;
        }
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = File.Create(Application.persistentDataPath + "/LuokeData/GameUnder.txt");
        binaryFormatter.Serialize(fileStream, JsonUtility.ToJson(this.GameUnder));
        fileStream.Close();

        //BinaryFormatter binaryFormatter2 = new BinaryFormatter();
        //FileStream fileStream2 = File.Create(Application.persistentDataPath + "Luoke/bag.txt");
        //binaryFormatter2.Serialize(fileStream2, JsonUtility.ToJson(this.Bag));
        //fileStream2.Close();
        //Text consoleTextContent = this.ConsoleText.ConsoleTextContent;
        //consoleTextContent.text += "管理员: 游戏保存完毕！\n";
        //Debug.Log("OK Save");
    }
    public void LoadGame()
    {
        try
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = File.Open(Application.persistentDataPath + "/LuokeData/GameUnder.txt", FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)binaryFormatter.Deserialize(fileStream), this.GameUnder);
            //FileStream fileStream2 = File.Open(Application.persistentDataPath + "Luoke/bag.txt", FileMode.Open);
            //JsonUtility.FromJsonOverwrite((string)binaryFormatter.Deserialize(fileStream2), this.Bag);
            fileStream.Close();
            //fileStream2.Close();
            //Text consoleTextContent = this.ConsoleText.ConsoleTextContent;
            //consoleTextContent.text += "管理员: 游戏加载完毕！\n";
            //Debug.Log("OK Load");
        }
        catch
        { }
    }
    private void Update()
    {
        SystemTime += Time.deltaTime;
        if (SystemTime > 0.1f)
        {
            SaveGame();
            SystemTime = 0f;
        }
    }
}
