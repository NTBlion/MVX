using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    private Model _model;

    public Model Model => _model;

    private void Awake()
    {
        _model = new Model();
    }
    
    public void OnEdit(string text)
    {
        _model.ChangeText(text);
    }

    public void OnClickMinusButton()
    {
        _model.RemoveValue();
    }

    public void OnClickPlusButton()
    {
        _model.AddValue();
    }
}
