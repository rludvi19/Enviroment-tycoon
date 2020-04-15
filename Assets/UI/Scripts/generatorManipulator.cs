using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorManipulator : MonoBehaviour
{
    private UIManager UI;
    public GameObject Generator;
    public GameObject CloseMenu;

    // Start is called before the first frame update
    void Start()
    {
        UI = FindObjectOfType<UIManager>();
        CloseMenu = GameObject.FindGameObjectWithTag("generatorManipulator");
        if(CloseMenu != null) {
            Destroy(CloseMenu);
        }
        this.gameObject.tag = "generatorManipulator";
    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(this.gameObject, 3);
    }

    public void deletion()
    {
        generatorBehavior behaviour;
        behaviour = Generator.GetComponent<generatorBehavior>();
        /*
         *  UI.Upkeep -= behaviour.Upkeep;
         *  UI.Energy -= behaviour.Energy;
         *  UI.PolutionPerRound -= behaviour.PolutionPerRound;
         *  UI.Happiness -= behaviour.Happiness;
         */
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
    
    public void close()
    {
        generatorBehavior behaviour;
        behaviour = Generator.GetComponent<generatorBehavior>();
        // behaviour.close();
        Destroy(gameObject);
    }

}
