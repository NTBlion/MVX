using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Button _plusBotton;
    [SerializeField] private Button _minusBotton;
    [SerializeField] private TMP_InputField _inputField;
    
    [SerializeField] private View _view;
    
    private Model _model;

    private void Awake()
    {
        _model = new Model();
    }

    private void OnEnable()
    {
        _plusBotton.onClick.AddListener(OnClickPlusButton);
        _minusBotton.onClick.AddListener(OnClickMinusButton);
        _inputField.onEndEdit.AddListener(OnEdit);
    }

    private void OnDisable()
    {
        _plusBotton.onClick.RemoveListener(OnClickPlusButton);
        _minusBotton.onClick.RemoveListener(OnClickMinusButton);
        _inputField.onEndEdit.RemoveListener(OnEdit);
    }

    private void OnEdit(string text)
    {
        _model.ChangeText(text);
        _view.ChangeStringValue(text);
    }

    private void OnClickMinusButton()
    {
        _model.RemoveValue();
        _view.ChangeIntValue(_model.Value);
    }

    private void OnClickPlusButton()
    {
        _model.AddValue();
        _view.ChangeIntValue(_model.Value);
    }
}
