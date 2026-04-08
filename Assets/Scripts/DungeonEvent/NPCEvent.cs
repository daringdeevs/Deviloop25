using UnityEngine;
using UnityEngine.Events;
using Yarn.Unity;

namespace Deviloop
{
    public class NPCEvent : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onStart;
        [SerializeField] private DialogueRunner _dialogueRunner;
        
        public void Setup(EventEncounterData encounterData)
        {
            _onStart?.Invoke();
        }
        
        public void OnDialogueComplete()
        {
            DungeonEventManager.OnDungeonEventFinishedEvent?.Invoke();
        }
    }
}
