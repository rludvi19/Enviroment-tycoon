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

    private generatorBehavior properties;

    // Start is called before the first frame update
    void Start()
    {
        properties = GetComponent<generatorBehavior>();
        manager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (placed && manager.Wealth >= properties.Price)
        {
            Vector3 direction = new Vector3(0, -1, 0);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag.Equals("metropolis"))
                {
                    this.gameObject.tag = "metropolis";
                    manager.Wealth -= properties.Price;
                    manager.Upkeep += properties.Upkeep;
                    manager.Energy += properties.Energy + 10;
                    manager.PollutionPerRound += properties.PollutionPerRound;
                    manager.Happiness += properties.Happiness - 10;
                    placed = false;
                }
                else if (hit.transform.tag.Equals("inland"))
                {
                    this.gameObject.tag = "inland";
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
            }
            else
            {
                placed = false;
                Destroy(gameObject);
            }
        }
    }
}