using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    [SerializeField] private View _view;
    
    private Model _model;
    
    private void Awake()
    {
        _model = new Model();
    }
    
    public void Edit(string text)
    {
        _model.ChangeText(text);
        _view.ChangeStringValue(text);
    }

    public void ClickMinusButton()
    {
        _model.RemoveValue();
        _view.ChangeIntValue(_model.Value);
    }

    public void ClickPlusButton()
    {
        _model.AddValue();
        _view.ChangeIntValue(_model.Value);
    }
}
