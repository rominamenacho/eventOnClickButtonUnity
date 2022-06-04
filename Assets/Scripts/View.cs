using System;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour, IView
{

    [SerializeField] public Button ButtonAccept;
    [SerializeField] public Text valueToShow;


    public event Action ButtonClicked = () => { };



    private void Start()
    {
        Presenter _presenter = new Presenter(this);

        ButtonAccept.onClick.AddListener(() =>
        {
            ButtonClicked.Invoke();
        });
    }

}
