using UnityEngine;

public class Presenter : MonoBehaviour
{
    private View _view;
    private Model _model;

    public void Init(View view, Model model)
    {
        _view = view;
        _model = model;

        _view.PlusButtonClicked += OnPlusButtonClicked;
        _view.MinusButtonClicked += OnMinusButtonClicked;
        _view.InputFieldEdited += OnInputFieldEdited;
    }

    private void OnInputFieldEdited(string text)
    {
        _model.ChangeText(text);
        _view.ChangeStringValue(text);
    }

    private void OnMinusButtonClicked()
    {
        _model.RemoveValue();
        _view.ChangeIntValue(_model.Value);
    }

    private void OnPlusButtonClicked()
    {
        _model.AddValue();
        _view.ChangeIntValue(_model.Value);
    }
}