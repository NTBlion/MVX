using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewModel : MonoBehaviour
{
    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;
    [SerializeField] private TMP_InputField _inputField;
    
    private int _viewIntValue;
    private string _viewStringValue;
    
    public event Action<int> ViewIntChanged;
    public event Action<string> ViewStringChanged;
    
    private Model _model;

    public void Init(Model model)
    {
        _model = model;
        _model.IntValueChanged += OnModelIntChanged;
        _model.StringValueChanged += OnModelStringChanged;
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
        
        _model.IntValueChanged -= OnModelIntChanged;
        _model.StringValueChanged -= OnModelStringChanged;
    }

    private void OnInputChanged(string text)
    {
        _inputField.text = text;
        ViewStringChanged?.Invoke(text);
    }

    private void OnMinusClicked()
    {
        _viewIntValue--;
        ViewIntChanged?.Invoke(_viewIntValue);
    }

    private void OnPlusClicked()
    {
        _viewIntValue++;
        ViewIntChanged?.Invoke(_viewIntValue);
    }
    
    private void OnModelStringChanged(string text)
    {
        _viewStringValue = text;
        ViewStringChanged?.Invoke(text);
    }

    private void OnModelIntChanged(int value)
    {
        _viewIntValue = value;
        ViewIntChanged?.Invoke(_viewIntValue);
    }
    
}
