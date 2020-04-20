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
            RaycastHit hit;
            Vector3 direction = new Vector3(0,-1,0);

            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
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
                Destroy(gameObject);
                placed = false;
           //  Destroy(gameObject);
            }
            
            

                    manager.Wealth -= properties.Price;
                    manager.Upkeep += properties.Upkeep;
                    manager.Energy += properties.Energy;
                    manager.PollutionPerRound += properties.PollutionPerRound;
                    manager.Happiness += properties.Happiness;
                    placed = false;

                }
                else if (hit.transform.tag.Equals("coast"))
                {
                    this.gameObject.tag = "coast";
                    manager.Wealth -= properties.Price + 10;
                    manager.Upkeep += properties.Upkeep;
                    manager.Energy += properties.Energy;
                    manager.PollutionPerRound += properties.PollutionPerRound;
                    manager.Happiness += properties.Happiness + 10;
                    placed = false;
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
