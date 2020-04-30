using UnityEngine;

namespace Events.Scripts
{
   public class EvenBehaviour : MonoBehaviour
   {
      public UIManager manager; 
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

               manager.Energy += 4 * coalGeneratorCount;

               break;
            
            case "Earthquake":
               var objectsInMetro = GameObject.FindGameObjectsWithTag("metropolis");

               foreach (var possibleGenerator in objectsInMetro)
               {
                  if (possibleGenerator.GetComponent<generatorBehavior>())
                  {
                     Destroy(possibleGenerator);
                  }
               }
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
