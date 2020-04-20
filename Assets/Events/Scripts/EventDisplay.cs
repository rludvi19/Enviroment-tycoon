using UnityEngine;
using UnityEngine.UI;

namespace Events.Scripts
{
    public class EventDisplay : MonoBehaviour
    {
        public Text nameText;
        public Text descriptionText;
        public Image artworkImage;

        public void DisplayEvent(EventTemplate selectedEventTemplate, GameObject uiPanel)
        {
            if (uiPanel != null)
            {
                uiPanel.SetActive(true);
                nameText.text = selectedEventTemplate.name;
                descriptionText.text = selectedEventTemplate.description;
                artworkImage.sprite = selectedEventTemplate.artwork;
            }
        }
    }
}
