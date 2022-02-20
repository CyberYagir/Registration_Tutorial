using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Palette : MonoBehaviour
{
    [SerializeField] private Slider r, g, b;
    [SerializeField] private Image colorPeview;
    [SerializeField] private UnityEvent OnChangeColor;
    
    private void Start()
    {
        ColorToSliders();
    }

    public void UpdateColor()
    {
        colorPeview.color = new Color(r.value, g.value, b.value, 1f);
        OnChangeColor.Invoke();
    }

    public void SetImageColor(Color color)
    {
        colorPeview.color = color;
        OnChangeColor.Invoke();
    }

    public Color GetColor()
    {
        return colorPeview.color;
    }
    
    public void ColorToSliders()
    {
        var color = colorPeview.color;
        r.value = color.r;
        g.value = color.g;
        b.value = color.b;
    }
}
