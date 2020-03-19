using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    //public GameObject uiManger;
    public bool placed = false;
    public GameObject center;

    private UIManager manager;
    public GameObject noMoney;
    public GameObject UI;

    private generatorBehavior properties;
    // Start is called before the first frame update
    void Start()
    {
        properties = GetComponent<generatorBehavior>();
        manager = FindObjectOfType<UIManager>();
        UI = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {

        if (placed && manager.Wealth >= properties.Price)
        {
            if (Vector3.Distance(this.transform.position, center.transform.position) < 55f)
            {
                this.gameObject.tag = "metropolis";
                manager.Wealth -= properties.Price;
                placed = false;
            }
            else if (Vector3.Distance(this.transform.position, center.transform.position) < 95f)
            {
                this.gameObject.tag = "inland";
                manager.Wealth -= properties.Price;
                placed = false;
            }
            else if (Vector3.Distance(this.transform.position, center.transform.position) < 143f)
            {
                this.gameObject.tag = "coast";
                manager.Wealth -= properties.Price;
                placed = false;
            }
            else
            {
                placed = false;
                Destroy(gameObject);
            }

        }
        else if(placed) {
            Destroy(gameObject);
            placed = false;
            Instantiate(noMoney, UI.transform);

        }
    }

}
