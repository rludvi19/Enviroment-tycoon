using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    //public GameObject uiManger;
    public bool placed = false;
    public bool build = false;
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
            RaycastHit hit;
            Vector3 direction = new Vector3(0,-1,0);

            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back));
                if (hit.transform.tag.Equals("metropolis"))
                {
                    this.gameObject.tag = "metropolis";
                    properties.Energy += 10;
                    manager.Wealth -= properties.Price;
                    properties.Happiness -= 10;
                    placed = false;
                    build = true;
                }
                else if (hit.transform.tag.Equals("inland"))
                {
                    this.gameObject.tag = "inland";
                    manager.Wealth -= properties.Price;
                    placed = false;
                    build = true;

                }
                else if (hit.transform.tag.Equals("coast"))
                {
                    this.gameObject.tag = "coast";
                    manager.Wealth -= properties.Price + 10;
                    properties.Happiness += 10;
                    placed = false;
                    build = true;
                }
                else
                {
                    placed = false;
                    Destroy(gameObject);
                }
            }
        }
    }
}
