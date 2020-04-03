using UnityEngine;

namespace Events.Event_Library
{
    [CreateAssetMenu(fileName = "New Event", menuName = "Create New Event")]
    public class EventTemplate : ScriptableObject
    {
        public new string name;
        public string description;

        public Sprite artwork; 
    }
}
