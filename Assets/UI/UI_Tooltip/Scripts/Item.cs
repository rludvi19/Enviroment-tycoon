using UnityEngine;
   
   namespace EnergiScript.TooltipUI
   {
       public abstract class Item : ScriptableObject
       {
           [SerializeField] private new string name;
           [SerializeField] private int price;
   
           public string Name { get { return name; } } 
           public abstract string ColouredName { get; }
           public int Price { get { return price; } }
   
           public abstract string GetTooltipInfoText();
       }
   }