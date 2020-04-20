using UnityEngine;

namespace UI.Tooltip.Scripts
   {
       public abstract class Item : ScriptableObject
           {
               public new string name;
               public int price;

               public abstract string ColouredName { get; }
               public abstract string GetTooltipInfoText();
           }
       }