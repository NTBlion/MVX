using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;
    [SerializeField] private TMP_InputField _inputField;
    
    [SerializeField] private TMP_Text _intText;
    [SerializeField] private TMP_Text _stringText;
    
    private ViewModel _viewModel;

    public void Init(ViewModel viewmodel)
    {
        _viewModel = viewmodel;
    }
    
    private void OnEnable()
    {
        _viewModel.ViewIntValue.Subscribe(ValueChanged);
        _viewModel.ViewStringValue.Subscribe(ViewStringChanged);

        _plusButton.OnClickAsObservable().Subscribe(x => OnPlusButtonClicked()).AddTo(this);
        _minusButton.OnClickAsObservable().Subscribe(x => OnMinusButtonClicked()).AddTo(this);
        _inputField.onValueChanged.AsObservable().Subscribe(OnInputEdited).AddTo(this);
    }
    
    private void OnPlusButtonClicked()
    {
        _viewModel.AddValue();
    }

    private void OnMinusButtonClicked()
    {
        _viewModel.RemoveValue();
    }

    private void OnInputEdited(string text)
    {
        _viewModel.EditInput(text);
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