using UnityEngine;

namespace Events.Scripts
{
   public class EvenBehaviour : MonoBehaviour
   {
      public GameObject manager; 
      public void dispatchEvent(ScriptableObject @event)
      {
         switch (@event.name)
         {
            case "Coal Mine Opened":
               var generators = FindObjectsOfType<generatorBehavior>();
               int coalGeneratorCount = 0;

               foreach (var generator in generators)
               {
                  if (generator.name.Equals("Coal(Clone)"))
                  {
                     coalGeneratorCount++;
                  }
               }
               

               break;
            
            case "Earthquake":
               break;
         
            case "Eureka!":
               break;

            case "Nuclear Disaster Overseas!":
               break;

            case "Political Scandal":
               break;

            case "Tsunami":
               break;

            case "Uranium Mother Lode Discovered":
               break;

            case "Wildfire":
               break;
         
            case "Won the World Cup":
               break;
         }
      }
   }
}
