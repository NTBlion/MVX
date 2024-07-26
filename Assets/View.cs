using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private TMP_Text _intText;
    [SerializeField] private TMP_Text _stringText;
    [SerializeField] private ViewModel _viewModel;

    private void OnEnable()
    {
        _viewModel.ViewIntValue.Subscribe(ValueChanged);
        _viewModel.ViewStringValue.Subscribe(ViewStringChanged);
    }

    public void ViewStringChanged(string text)
    {
        _stringText.text = text;
    }
    
    public void ValueChanged(int value)
    {
        _intText.text = value.ToString();
    }
}