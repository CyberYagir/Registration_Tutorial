using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActive : MonoBehaviour
{
    [SerializeField] private Color selectedC, noneC;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }


    public void Select(bool isSelected)
    {
        image.color = isSelected ? selectedC : noneC;
    }

    public void ButtonClick()
    {
        GetComponent<Button>().onClick.Invoke();
    }
}
