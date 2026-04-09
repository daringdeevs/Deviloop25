using UnityEngine;
using UnityEngine.Events;
using Yarn.Unity;

namespace Deviloop
{
    public class NPCEvent : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onStart;
        [SerializeField] private UnityEvent _onDialogueComplete;
        [SerializeField] private DialogueRunner _dialogueRunner;
        [SerializeField] private GameObject _dialogueUI;
        
        private EventEncounterData _encounterData;
        
        public void Setup(EventEncounterData encounterData)
        {
            _onStart?.Invoke();
            _encounterData =  encounterData;

        }

        public void OnEnterAnimationEnd()
        {
            _dialogueUI.SetActive(true);
            
            _dialogueRunner.SetProject(_encounterData.YarnProject);
            _dialogueRunner.StartDialogue(_encounterData.StartNodeName);
            
            _dialogueRunner.onDialogueComplete?.AddListener(OnDialogueComplete);
        }
        
        private void OnDialogueComplete()
        {
            _onDialogueComplete?.Invoke();
            _dialogueRunner.onDialogueComplete?.RemoveListener(OnDialogueComplete);
        }
        
        public void OnEncounterFinish()
        {
            DungeonEventManager.OnDungeonEventFinishedEvent?.Invoke();
        }
    }
}
