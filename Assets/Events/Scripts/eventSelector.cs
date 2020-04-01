using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventSelector : MonoBehaviour
{
    [SerializeField] private GameObject UIPanel;
    [SerializeField] private GameObject manager;

    private void Start()
    {
        UIManager stats = manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void selectEvent()
    {
        //PlaceHolder
    }
}
