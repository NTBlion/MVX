using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] private ViewModel _viewModel;
    [SerializeField] private View _view;
    private Model _model;

    private ReactiveProperty<int> _zero = new ReactiveProperty<int>();
    private ReactiveProperty<string> _empty = new ReactiveProperty<string>();

    private void Awake()
    {
        _model = new Model(_zero, _empty, _view);
        _viewModel = new ViewModel(_model);
        _view.Init(_viewModel);
    }
}
