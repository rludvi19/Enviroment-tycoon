using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Tooltip.Scripts
{
    public class ItemButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private TooltipPopup tooltipPopup;
        [SerializeField] private Item item;

        public void OnPointerEnter(PointerEventData eventData)
        {
            tooltipPopup.DisplayInfo(item);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tooltipPopup.HideInfo();
        }
    }
}
