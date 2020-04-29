using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
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

    [FormerlySerializedAs("PolutionDisplay")] [Header("Pollution")]
    public GameObject PollutionDisplay;
    [FormerlySerializedAs("Polution")] public int Pollution;
    private Text PolutionComponent;

    [FormerlySerializedAs("PolutionPerRoundDisplay")] [Header("Pollution Per Round")]
    public GameObject PollutionPerRoundDisplay;
    [FormerlySerializedAs("PolutionPerRound")] public int PollutionPerRound;
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
    
    [Header("Current Event")]
    public GameObject CurEventDisplay;
    public string CurEvent;
    private Text CurEventComponent;
    
    [Header("Turn Counter")]
    public GameObject TurnCountDisplay;
    public string TurnCount;
    private Text TurnCountComponent;

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
        PolutionComponent = PollutionDisplay.GetComponent<Text>();
        PolutionPerRoundComponent = PollutionPerRoundDisplay.GetComponent<Text>();
        wealthComponent = WealthDisplay.GetComponent<Text>();
        UpkeepComponent = UpkeepDisplay.GetComponent<Text>();
        EnergyComponent = EnergyDisplay.GetComponent<Text>();
        PopulationComponent = PopulationDisplay.GetComponent<Text>();
        CurEventComponent = CurEventDisplay.GetComponent<Text>();
        TurnCountComponent = TurnCountDisplay.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HappinessComponent.text = Happiness*10 + "";
        PolutionComponent.text = Pollution + "";
        wealthComponent.text = Wealth + "";
        UpkeepComponent.text = Upkeep + "";
        PopulationComponent.text = population + "";
        EnergyComponent.text = Energy + "";
        PolutionPerRoundComponent.text = PollutionPerRound + "";
        CurEventComponent.text = "Current Event: " + CurEvent;
        TurnCountComponent.text = "END TURN:" + TurnCount;
    }
}
