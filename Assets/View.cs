using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private TMP_Text _intValue;
    [SerializeField] private TMP_Text _stringValue;
    
    public void ChangeIntValue(int value)
    {
        _intValue.text = value.ToString();
    }

    public void ChangeStringValue(string value)
    {
        _stringValue.text = value;
    }
}
