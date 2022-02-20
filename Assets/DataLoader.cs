using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Palette main, second;
    [SerializeField] private WebManager manager;
    [Space] [SerializeField] private Color startMainColor, startSecondColor;
    public void LoadData()
    {
        nameInput.text = WebManager.userData.playerData.nickname;
        if (WebManager.userData.playerData.colorMain != "Null")
        {
            main.SetImageColor(JsonUtility.FromJson<Color>(WebManager.userData.playerData.colorMain));
        }
        else
        {
            main.SetImageColor(startMainColor);
        }

        if (WebManager.userData.playerData.colorSecond != "Null")
        {
            second.SetImageColor(JsonUtility.FromJson<Color>(WebManager.userData.playerData.colorSecond));
        }
        else
        {
            second.SetImageColor(startSecondColor);
        }
    }


    public void SaveData()
    {
        var player = WebManager.userData.playerData;
        manager.SaveData(player.id, player.nickname, player.colorMain, player.colorSecond);
    }
}
