using UnityEngine;

public class MainScript : MonoBehaviour
{
    private Model _model;
    private Controller _controller;
    [SerializeField] private View _view;

    private void Awake()
    {
        _model = new Model();
        _controller = new Controller();
        _controller.Init(_view, _model);
        _view.Init(_controller);
    }
}
