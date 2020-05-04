using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events.Scripts
{
    public class CurrentEvent : MonoBehaviour
    {   
        private EventTemplate selectedEvent;

        private EventTemplate GetEventTemplate(EventTemplate @event)
        {
            return @event; 
        }

        private void CoalMineOpenedEven()
        {
            generatorBehavior[] generators = FindObjectsOfType<generatorBehavior>();
            List<generatorBehavior> coalGenerators = new List<generatorBehavior>();

            foreach (generatorBehavior generator in generators)
            {
                if (generator.name.Equals("Coal(Clone)"))
                {
                    coalGenerators.Add(generator);
                }                
            }
        }

        private void EarthquakeEvent()
        {
            
        }

        private void EurekaEvent()
        {
            
        }

        private void NuclearDisasterOverseasEvent()
        {
            
        }

        private void PoliticalScandalEvent()
        {
            
        }


    }
}
