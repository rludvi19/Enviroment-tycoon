using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Happiness")]
    public GameObject HappinessDisplay;
    [Range(0, 8)]
    public int Happiness;
    private Slider HappinessComponent;

    [Header("Wealth")]
    public GameObject WealthDisplay;
    public int Wealth;
    private Text wealthComponent;

    [Header("Pollution")]
    public GameObject PolutionDisplay;
    [Range(0, 10)]
    public int Polution;
    private Slider PolutionComponent;

    // Start is called before the first frame update
    void Start()
    {
        HappinessComponent = HappinessDisplay.GetComponent<Slider>();
        PolutionComponent = PolutionDisplay.GetComponent<Slider>();
        wealthComponent = WealthDisplay.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HappinessComponent.value = Happiness;
        PolutionComponent.value = Polution;
        wealthComponent.text = Wealth + " $";
    }
}
