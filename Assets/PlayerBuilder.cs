using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBuilder : MonoBehaviour
{
    [SerializeField] private Renderer mainR, secondR;
    [SerializeField] private TMP_Text nicknameT;
    
    
    
    public void ChangeMainColor(Palette color)
    {
        mainR.material.color = color.GetColor();
        WebManager.userData.playerData.SetMainColor(JsonUtility.ToJson(color.GetColor()));
    }
    public void ChangeSecondColor(Palette color)
    {
        secondR.material.color = color.GetColor();
        WebManager.userData.playerData.SetSecondColor(JsonUtility.ToJson(color.GetColor()));
    }
    public void ChangeNickName(TMP_Text newName)
    {
        nicknameT.text = newName.text;
        WebManager.userData.playerData.nickname = newName.text;
    }
}
