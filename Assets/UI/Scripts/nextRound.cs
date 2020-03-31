using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRound : MonoBehaviour
{
    public GameObject Manager;
    public GameObject Events;
    private UIManager Stats;

    // Start is called before the first frame update
    void Start()
    {
        Stats = Manager.gameObject.GetComponent<UIManager>();
        next();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void next()
    {
        Stats.Wealth += Stats.IncomePerCitizen;
        Stats.Wealth -= Stats.Upkeep;
        if (Stats.Energy > Stats.population * Stats.EnergyNeededPerCitizen)
        {
            Stats.Happiness += 1;
            Stats.Wealth += (Stats.Energy - Stats.population * Stats.EnergyNeededPerCitizen) * Stats.PrizeForExessEnergy;
        }
        else if (Stats.Energy == Stats.population * Stats.EnergyNeededPerCitizen)
        {
            Stats.Happiness += 1;
        }
        else if (Stats.Energy < Stats.population * Stats.EnergyNeededPerCitizen)
        {
            Stats.Happiness += (Stats.Energy / Stats.EnergyNeededPerCitizen) - Stats.population;
        }
        Stats.population += Stats.PopulationIncreasePerRound;
        Stats.Pollution += Stats.PollutionPerRound;
    }
}
