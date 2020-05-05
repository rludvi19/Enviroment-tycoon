using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events.Scripts
{
    public class CurrentEvent : MonoBehaviour
    {
        private UIManager gameManager;
        private int lifeTime;
        private int eventDuration;

        public float energyMod = 1; 
        public float happinessMod = 1; 
        public float pollutionMod = 1;

        public delegate void ActiveEvent();

        private void Awake()
        {
            gameManager = FindObjectOfType<UIManager>();
            lifeTime = 0;
        }

        public void UpdateStatus() //Is called on Next Round 
        {
            lifeTime++;

            if (lifeTime >= eventDuration)
            {
                Destroy(gameObject);
            }
        }

        public void CoalMineOpenedEvent()
        {
            eventDuration = 3;

            energyMod += 0.2f; 
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
