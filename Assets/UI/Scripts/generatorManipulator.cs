using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorManipulator : MonoBehaviour
{
    private UIManager UI;
    public GameObject Generator;

    // Start is called before the first frame update
    void Start()
    {
        UI = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void deletion()
    {
        generatorBehavior behaviour;
        behaviour = Generator.GetComponent<generatorBehavior>();

          UI.Upkeep -= behaviour.Upkeep;
          UI.Energy -= behaviour.Energy;
          UI.PollutionPerRound -= behaviour.PollutionPerRound;
          UI.Happiness -= behaviour.Happiness;
         
        Destroy(this.Generator);
        Destroy(gameObject);
    }

    public void upgrade()
    {
        generatorBehavior behaviour;
        behaviour = Generator.GetComponent<generatorBehavior>();
        // behaviour.Upgrade();
        Destroy(gameObject);
    }

}
