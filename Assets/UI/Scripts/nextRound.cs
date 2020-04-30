using System;
using System.Collections.Generic;
using Events.Scripts;
using UnityEngine;
using Random = UnityEngine.Random;

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
            resetAllGenerators();
            
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

            if (selectedEvent != null)
            {
                EventPanel.GetComponent<EvenBehaviour>().dispatchEvent(selectedEvent);
            }

            selectedEvent = SelectEvent();

            EventPanel.GetComponent<EventDisplay>().DisplayEvent(selectedEvent, EventPanel);
        }

        private void resetAllGenerators()
        {
            generatorBehavior coalTemplate = GameObject.Find("Coal").GetComponent<generatorBehavior>();
            generatorBehavior windTemplate = GameObject.Find("Wind").GetComponent<generatorBehavior>();
            generatorBehavior nuclearTemplate = GameObject.Find("Atom").GetComponent<generatorBehavior>();

            var allGeneratorBehaviors = FindObjectsOfType<generatorBehavior>();

            foreach (var generator in allGeneratorBehaviors)
            {
                if (generator.name.Equals("Coal(Clone)"))
                {
                    generator.Energy = coalTemplate.Energy;
                }
                
                if (generator.name.Equals("Wind(Clone)"))
                {
                    generator.Energy = windTemplate.Energy;
                }

                if (generator.name.Equals("Atom(Clone)"))
                {
                    generator.Energy = nuclearTemplate.Energy;
                }
            }
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