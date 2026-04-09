using UnityEngine;
using Yarn.Unity;
using Yarn.Unity.Attributes;

namespace Deviloop
{
    [CreateAssetMenu(fileName = "EventEncounterData", menuName = "Scriptable Objects/EventEncounterData")]
    public class EventEncounterData : ScriptableObject
    { 
        public GameObject NPCPrefab;
        public YarnProject YarnProject;
        [YarnNode(nameof(YarnProject))]
        public string StartNodeName = "Start";
    }
}
