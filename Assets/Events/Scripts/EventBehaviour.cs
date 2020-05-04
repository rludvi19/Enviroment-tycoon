using System;
using System.Collections;
using System.Runtime.InteropServices;
using UI.Scripts;
using UnityEngine;

namespace Events.Scripts
{
    public class EventBehaviour : MonoBehaviour
    {
        public UIManager manager;
        private NextRound nextRoundHandler;

        private void Awake()
        {
            nextRoundHandler = GameObject.Find("EventSystem").GetComponent<NextRound>(); 
        }


        public void dispatchEvent(ScriptableObject @event)
        {
            switch (@event.name)
            {
                case "Coal Mine Opened":
                    break;

                case "Earthquake":
                    
                    break;
                case "Eureka!":
                    //Instantly aquire the next upgrade
                    break;
                case "Nuclear Disaster Overseas!":
                    //Reduce happiness for each nuclear power plant 
                    break;
                case "Political Scandal":
                    //reduce happiness 
                    break;
                case "Tsunami":
                    //destroy beach generators 
                    break;
                case "Uranium Mother Lode Discovered":
                    //More power from atom 
                    break;
                case "Wildfire":
                    //Destroy inland 
                    break;
                case "Won the World Cup":
                    //Buff happiness 
                    break;
            }
        }
    }
}

