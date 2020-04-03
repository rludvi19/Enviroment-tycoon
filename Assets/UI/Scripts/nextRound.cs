using System.Collections;
using System.Collections.Generic;
using Events.Event_Library;
using Events.Scripts;
using UnityEngine;

public class NextRound : MonoBehaviour
{
    public GameObject UIPanel;
    public GameObject Manager;
    private UIManager Stats;

    public List<EventTemplate> events;
    private EventTemplate selectedEvent;

    public void Start()
    {
        Stats = Manager.gameObject.GetComponent<UIManager>();
        events = GetAllEvents();
        Next();
    }
    
    private void Next()
    {
        Stats.Wealth += Stats.IncomePerCitizen;
        Stats.Wealth -= Stats.Upkeep;
        if (Stats.Energy > Stats.population * Stats.EnergyNeededPerCitizen)
        {
            Stats.Happiness += 1;
            Stats.Wealth += (Stats.Energy - Stats.population * Stats.EnergyNeededPerCitizen) *
                            Stats.PrizeForExessEnergy;
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

        selectedEvent = SelectEvent();
        
        UIPanel.GetComponent<EventDisplay>().DisplayEvent(selectedEvent, UIPanel);
    }

    private EventTemplate SelectEvent()
    {
        EventTemplate selectedEvent = events[Random.Range(0, events.Count)];
        return selectedEvent;
    }

    static List<EventTemplate> GetAllEvents()
    {
        List<EventTemplate> objectsInScene = new List<EventTemplate>();

        foreach (EventTemplate go in Resources.FindObjectsOfTypeAll(typeof(EventTemplate)) as EventTemplate[])
        {
            if (!(go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave))
            {
                objectsInScene.Add(go);
            }
        }
        return objectsInScene;
    }
}