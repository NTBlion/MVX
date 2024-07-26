using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] private Presenter _presenter;
    [SerializeField] private View _view;
    private Model _model;

    private void Awake()
    {
        _model = new Model();
        _presenter.Init(_view,_model);
    }
}