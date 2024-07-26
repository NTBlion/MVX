using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ViewModel : MonoBehaviour
{
    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;
    [SerializeField] private TMP_InputField _inputField;

    private ReactiveProperty<int> _viewIntValue;
    private ReactiveProperty<string> _viewStringValue;

    private Model _model;

    public ReactiveProperty<int> ViewIntValue => _viewIntValue;
    public ReactiveProperty<string> ViewStringValue => _viewStringValue;

    public void Init(Model model)
    {
        _model = model;

        _model.Value.Subscribe(x => _viewIntValue = _model.Value);

        _model.StringValue.Subscribe(x => _viewStringValue = _model.StringValue);
    }

    private void OnEnable()
    {
        _plusButton.onClick.AddListener(OnPlusClicked);
        _minusButton.onClick.AddListener(OnMinusClicked);
        _inputField.onValueChanged.AddListener(OnInputChanged);
    }

    private void OnDisable()
    {
        _plusButton.onClick.RemoveListener(OnPlusClicked);
        _minusButton.onClick.RemoveListener(OnMinusClicked);
        _inputField.onValueChanged.RemoveListener(OnInputChanged);
    }

    private void OnPlusClicked()
    {
        _viewIntValue.Value++;
    }

    private void OnMinusClicked()
    {
        _viewIntValue.Value--;
    }

    private void OnInputChanged(string text)
    {
        _viewStringValue.Value = text;
    }
}