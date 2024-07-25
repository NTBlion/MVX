using System;

public class Model : IDisposable
{
    private int _value;
    private string _textValue;
    private View _view;

    public event Action<int> IntValueChanged;
    public event Action<string> StringValueChanged;

    public Model(int value, string textValue, View view)
    {
        _value = value;
        _textValue = textValue;
        _view = view;

        _view.IntChanged += OnIntChanged;
        _view.StringValueChanged += OnStringChanged;
    }
    
    public void Dispose()
    {
        _view.IntChanged -= OnIntChanged;
        _view.StringValueChanged -= OnStringChanged;
    }
    
    private void OnStringChanged(string text)
    {
        _textValue = text;
    }

    private void OnIntChanged(int value)
    {
        _value = value;
    }

    private void AddValue()
    {
        _value++;
        IntValueChanged?.Invoke(_value);
    }

    private void RemoveValue()
    {
        _value--;
        IntValueChanged?.Invoke(_value);
    }

    private void ChangeText(string text)
    {
        _textValue = text;
        StringValueChanged?.Invoke(_textValue);
    }
    
}
