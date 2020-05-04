using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events.Scripts
{
    public class CurrentEvent : MonoBehaviour
    {   
        private UIManager gameManager; 

        private void Awake() 
        {
            gameManager = FindObjectOfType<UIManager>();
        }

        private void CoalMineOpenedEven()
        {
            foreach (generatorBehavior generator in gameManager.coalGeneratorList)
            {
                generator.Energy = Mathf.RoundToInt((float) generator.Energy * 1.2f);
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
