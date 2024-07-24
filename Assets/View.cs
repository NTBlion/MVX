using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private TMP_Text _intValue;
    [SerializeField] private TMP_Text _stringValue;
    [SerializeField] private Presenter _presenter;
    
    [SerializeField] private Button _plusBotton;
    [SerializeField] private Button _minusBotton;
    [SerializeField] private TMP_InputField _inputField;

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
    
    public void ChangeIntValue(int value)
    {
        _intValue.text = value.ToString();
    }

    public void ChangeStringValue(string value)
    {
        _stringValue.text = value;
    }
    
    private void OnEdit(string text)
    {
        _presenter.Edit(text);
    }

    private void OnClickMinusButton()
    {
        _presenter.ClickMinusButton();
    }

    private void OnClickPlusButton()
    {
        _presenter.ClickPlusButton();
    }
}
