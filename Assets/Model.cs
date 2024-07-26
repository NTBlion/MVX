using System;
using UniRx;
using UnityEngine;

public class Model
{
    private ReactiveProperty<int> _value;
    private ReactiveProperty<string> _stringValue;
    private View _view;
    
    public Model(ReactiveProperty<int> value, ReactiveProperty<string> stringValue, View view)
    {
        _value = value;
        _stringValue = stringValue;
        _view = view;
    }

    public ReactiveProperty<int> Value => _value;
    public ReactiveProperty<string> StringValue => _stringValue;

    private void AddValue()
    {
        _value.Value++;
        _view.ValueChanged(_value.Value);
    }

    private void RemoveValue()
    {
        _value.Value--;
        _view.ValueChanged(_value.Value);
    }

    private void ChangeText(string text)
    {
        _stringValue.Value = text;
        _view.ViewStringChanged(_stringValue.Value);
    }
    
}
