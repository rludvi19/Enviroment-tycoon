using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Happiness")]
    public GameObject HappinessDisplay;
    public int Happiness;
    private Text HappinessComponent;

    [Header("Wealth")]
    public GameObject WealthDisplay;
    public int Wealth;
    private Text wealthComponent;

    [Header("Pollution")]
    public GameObject PolutionDisplay;
    public int Polution;
    private Text PolutionComponent;

    [Header("PollutionPerRound")]
    public GameObject PolutionPerRoundDisplay;
    public int PolutionPerRound;
    private Text PolutionPerRoundComponent;

    [Header("Energy")]
    public GameObject EnergyDisplay;
    public int Energy;
    private Text EnergyComponent;

    [Header("Upkeep")]
    public GameObject UpkeepDisplay;
    public int Upkeep;
    private Text UpkeepComponent;

    [Header("Population")]
    public GameObject PopulationDisplay;
    public int population;
    private Text PopulationComponent;

    [Header("Balancing")]
    [Header("______________________________________________________________________________________________")]
    public int PopulationIncreasePerRound = 2;
    public int IncomePerCitizen = 1;
    public int EnergyNeededPerCitizen = 1;
    public int PrizeForExessEnergy = 1;


    // Start is called before the first frame update
    void Start()
    {
        HappinessComponent = HappinessDisplay.GetComponent<Text>();
        PolutionComponent = PolutionDisplay.GetComponent<Text>();
        PolutionPerRoundComponent = PolutionPerRoundDisplay.GetComponent<Text>();
        wealthComponent = WealthDisplay.GetComponent<Text>();
        UpkeepComponent = UpkeepDisplay.GetComponent<Text>();
        EnergyComponent = EnergyDisplay.GetComponent<Text>();
        PopulationComponent = PopulationDisplay.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HappinessComponent.text = Happiness*10 + " %";
        PolutionComponent.text = Polution + " ☁";
        wealthComponent.text = Wealth + " $";
        UpkeepComponent.text = Upkeep + "  $";
        PopulationComponent.text = population + " 웃";
        EnergyComponent.text = Energy + " ϟ";
        PolutionPerRoundComponent.text = PolutionPerRound + " ☁";
    }

    public void next()
    {
        Wealth += IncomePerCitizen;
        Wealth -= Upkeep;
        if (Energy > population * EnergyNeededPerCitizen)
        {
            Happiness += 1;
            Wealth += (Energy - population * EnergyNeededPerCitizen) * PrizeForExessEnergy;
        }
        else if (Energy == population * EnergyNeededPerCitizen)
        {
            Happiness += 1;
        }
        else if (Energy < population * EnergyNeededPerCitizen)
        {
            Happiness += (Energy / EnergyNeededPerCitizen) - population;
        }
        population += PopulationIncreasePerRound;
        Polution += PolutionPerRound;


    }
}
