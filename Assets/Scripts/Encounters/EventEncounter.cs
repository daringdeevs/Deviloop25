using UnityEngine;

namespace Deviloop
{
    [CreateAssetMenu(fileName = "Encounter_Event_A00_00", menuName = "Scriptable Objects/Encounters/Event Encounter")]
    public class EventEncounter : BaseEncounter
    {
        [SerializeField] private EventEncounterData _eventEncounterData;

        public override void ResetEncounter()
        {
            EncounterManager.OnEncounterFinished -= FinishEncounter;
        }

        public override void StartEncounter()
        {
            InputSettings.IsGameplayInputBlocked = true;
            
            DungeonEventManager.OnStartEvent?.Invoke(_eventEncounterData);
            DungeonEventManager.OnDungeonEventFinishedEvent += FinishEncounter;
        }

        public override void FinishEncounter()
        {
            InputSettings.IsGameplayInputBlocked = false;
            
            DungeonEventManager.OnDungeonEventFinishedEvent -= FinishEncounter;
            EncounterManager.OnEncounterFinished?.Invoke();
        }
    }
}
