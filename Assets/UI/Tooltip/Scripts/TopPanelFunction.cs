using System.Text;
using UnityEngine;

namespace UI.Tooltip.Scripts


{
    [CreateAssetMenu(fileName = "New Function", menuName = "Items/Function")]
    
    public class TopPanelFunction : Item
    {
        [SerializeField] private TypeColor typeColor;
        [SerializeField] private string useText = "Something";
        [SerializeField] public string iconImage;
        [SerializeField] public Sprite displayImage;

        public Sprite DisplayImage {get {return displayImage;}}

        public TypeColor EnergyType { get { return typeColor; } }

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
            builder.Append("<color=white>Description: ").Append(useText).Append("</color>").AppendLine();
            builder.Append(iconImage).Append(DisplayImage).Append("Amount").AppendLine();

            return builder.ToString();
        }
        
    }
}