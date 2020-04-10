using System.Text;
using UnityEngine;

namespace EnergiScript.TooltipUI
{
    [CreateAssetMenu(fileName = "New Consumable", menuName = "Items/Consumable")]
    public class Consumable : Item
    {
        [SerializeField] private EnergyType energyType;
        [SerializeField] private string useText = "Something";

        public EnergyType EnergyType { get { return energyType; } }

        public override string ColouredName
        {
            get
            {
                string hexColour = ColorUtility.ToHtmlStringRGB(energyType.TextColour);
                return $"<color=#{hexColour}>{Name}</color>";
            }
        }

        public override string GetTooltipInfoText()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(EnergyType.Name).AppendLine();
            builder.Append("<color=green>Description: ").Append("</color>").Append(useText).AppendLine();
            builder.Append("Price: ").Append(Price).Append(" Gold");

            return builder.ToString();
        }
    }
}