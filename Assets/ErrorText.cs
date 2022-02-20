using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ErrorText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;


    public void DisplayError()
    {
        gameObject.SetActive(true);
        text.text = "Error: " + WebManager.userData.error.errorText;
    }
}
