using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Happiness")]
    public GameObject HappinessDisplay;
    public int Happiness;
    private Slider HappinessComponent;

    [Header("Wealth")]
    public GameObject WealthDisplay;
    public int Wealth;
    private Text wealthComponent;

    [Header("Pollution")]
    public GameObject PolutionDisplay;
    [Range(0,10)]
    public int Polution;
    private Slider PolutionComponent;

    [Header("PollutionPerRound")]
    public GameObject PolutionPerRoundDisplay;
    public int PolutionPerRound;
    private Text PolutionPerRoundComponent;

    [Header("Upkeep")]
    public GameObject UpkeepDisplay;
    public int Upkeep;
    private Text UpkeepComponent;

    [Header("Population")]
    public GameObject PopulationDisplay;
    public int population;
    private Text PopulationComponent;

    // Start is called before the first frame update
    void Start()
    {
        HappinessComponent = HappinessDisplay.GetComponent<Slider>();
        PolutionComponent = PolutionDisplay.GetComponent<Slider>();
        PolutionPerRoundComponent = PolutionPerRoundDisplay.GetComponent<Text>();
        wealthComponent = WealthDisplay.GetComponent<Text>();
        UpkeepComponent = UpkeepDisplay.GetComponent<Text>();
        PopulationComponent = PopulationDisplay.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HappinessComponent.value = Happiness;
        PolutionComponent.value = Polution;
        wealthComponent.text = Wealth + " $";
        UpkeepComponent.text = Upkeep + "  $";
        PopulationComponent.text = population + " 웃";
        PolutionPerRoundComponent.text = PolutionPerRound + " ☁";
    }

    public void nextRound() { 
        
    }
}
