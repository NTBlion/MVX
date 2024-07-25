using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private TMP_Text _intText;
    [SerializeField] private TMP_Text _stringText;
    [SerializeField] private ViewModel _viewModel;

    public event Action<int> IntChanged;
    public event Action<string> StringValueChanged;

    private void OnEnable()
    {
        _viewModel.ViewIntChanged += ValueChanged;
        _viewModel.ViewStringChanged += ViewStringChanged;
    }

    private void OnDisable()
    {
        _viewModel.ViewIntChanged -= ValueChanged;
    }

    private void ViewStringChanged(string text)
    {
        _stringText.text = text;
        StringValueChanged?.Invoke(text);
    }
    
    private void ValueChanged(int value)
    {
        _intText.text = value.ToString();
        IntChanged?.Invoke(value);
    }
}