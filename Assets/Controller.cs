public class Controller
{
    private View _view;
    private Model _model;

    public void Init(View view, Model model)
    {
        _view = view;
        _model = model;
    }
    
    public void Edit(string text)
    {
        _model.ChangeText(text);
        _view.ChangeStringValue(text);
    }

    public void ClickMinusButton()
    {
        _model.RemoveValue();
        _view.ChangeIntValue(_model.Value);
    }

    public void ClickPlusButton()
    {
        _model.AddValue();
        _view.ChangeIntValue(_model.Value);
    }
}
