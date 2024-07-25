using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] private ViewModel _viewModel;
    [SerializeField] private View _view;
    private Model _model;

    private void Awake()
    {
        _model = new Model(0, "", _view);
        _viewModel.Init(_model);
    }
}
