public class Model
{
    private int _value;
    private string _textValue;

    public int Value => _value;

    public void AddValue()
    {
        _value++;
    }

    public void RemoveValue()
    {
        _value--;
    }

    public void ChangeText(string text)
    {
        _textValue = text;
    }
}
