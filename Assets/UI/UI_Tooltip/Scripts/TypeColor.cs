using UnityEngine;

namespace EnergiScript.TooltipUI
{
    [CreateAssetMenu]
    public class TypeColor : ScriptableObject
    {
        [SerializeField] private new string name;
        [SerializeField] private Color textColour;

        public string Name { get { return name; } }
        public Color TextColour { get { return textColour; } }
    }
}