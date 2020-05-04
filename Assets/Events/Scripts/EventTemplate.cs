using UnityEngine;

namespace Events.Scripts
{
    [CreateAssetMenu(fileName = "New Event", menuName = "Create New Event")]
    public class EventTemplate : ScriptableObject
    {
        public new string name;
        
        [TextArea(10,20)]
        public string description;

        public Sprite artwork;
    }
}
