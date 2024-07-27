using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ViewModel
{
    private ReactiveProperty<int> _viewIntValue;
    private ReactiveProperty<string> _viewStringValue;

    private Model _model;

    public ReactiveProperty<int> ViewIntValue => _viewIntValue;
    public ReactiveProperty<string> ViewStringValue => _viewStringValue;

    public ViewModel(Model model)
    {
        _model = model;

        _model.Value.Subscribe(x => _viewIntValue = _model.Value);

        _model.StringValue.Subscribe(x => _viewStringValue = _model.StringValue);
    }
    
    public void AddValue()
    {
        _viewIntValue.Value++;
    }

    public void RemoveValue()
    {
        _viewIntValue.Value--;
    }

    public void EditInput(string text)
    {
        _viewStringValue.Value = text;
    }
}