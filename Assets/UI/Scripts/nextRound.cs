using System.Collections.Generic;
using Events.Scripts;
using UnityEngine;

namespace UI.Scripts
{
    public class NextRound : MonoBehaviour
    {
        public GameObject EventPanel;
        public GameObject Manager;
        private UIManager Stats;

        public List<EventTemplate> events;
        private EventTemplate selectedEvent;

        public void Start()
        {
            Stats = Manager.gameObject.GetComponent<UIManager>();
        }
    
        public void Next()
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
        
            EventPanel.GetComponent<EventDisplay>().DisplayEvent(selectedEvent, EventPanel);
        }

        private EventTemplate SelectEvent()
        {
            EventTemplate chosenEvent = events[Random.Range(0, events.Count)];
            return chosenEvent;
        }

        /*static List<EventTemplate> GetAllEvents()
        {
            List<EventTemplate> objectsInScene = new List<EventTemplate>();

            foreach (EventTemplate go in Resources.FindObjectsOfTypeAll(typeof(EventTemplate)) as EventTemplate[])
            {
                objectsInScene.Add(go);
            }
            return objectsInScene;
        }*/
    }
}