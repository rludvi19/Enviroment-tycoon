using System.Text;
using UnityEngine;

namespace UI.Tooltip.Scripts
{
    [CreateAssetMenu(fileName = "New Consumable", menuName = "Items/Consumable")]
    public class Consumable : Item
    {
        [SerializeField] private TypeColor typeColor;
        [SerializeField] private string useText = "Something";

        public override string ColouredName
        {
            get
            {
                string hexColour = ColorUtility.ToHtmlStringRGB(typeColor.TextColour);
                return $"<color=#{hexColour}>{name}</color>";
            }
        }

        public override string GetTooltipInfoText()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(typeColor.Name).AppendLine();
            builder.Append("<color=green><size=25>Description: ").Append("</color>").Append(useText).AppendLine();
            builder.Append("Price: ").Append(price).Append(" Gold");

            return builder.ToString();
        }
    }
}