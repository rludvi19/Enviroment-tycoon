using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorBehavior : MonoBehaviour
{
    private GameObject UI;
    public GameObject Menu;
    public int Price = 5;
    public int Upkeep = 2;
    public int Energy = 2;
    public int PollutionPerRound = 1;
    public int Happiness = 2;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnMouseOver()
    {
    }

    private void OnMouseDown()
    {
        GameObject MenuObject = Instantiate(Menu, this.transform.position, UI.transform.rotation);
        MenuObject.transform.parent = UI.transform;
        MenuObject.GetComponent<generatorManipulator>().Generator = this.gameObject;
    }
}
