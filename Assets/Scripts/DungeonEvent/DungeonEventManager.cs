using System;
using UnityEngine;

namespace Deviloop
{
    public class DungeonEventManager : MonoBehaviour, IInitiatable
    {
        public static Action<EventEncounterData> OnStartEvent;
        public static Action OnDungeonEventFinishedEvent;

        private GameObject _currentNPCPrefab;


        public void Initiate()
        {
            OnStartEvent += OnEncounterEntered;
            OnDungeonEventFinishedEvent += FinishEvent;
            gameObject.SetActive(false);
        }

        public void Deactivate()
        {
            OnDungeonEventFinishedEvent -= FinishEvent;
            OnStartEvent -= OnEncounterEntered;
        }

        private void OnEncounterEntered(EventEncounterData encounterData)
        {
            gameObject.SetActive(true);
            _currentNPCPrefab = Instantiate(encounterData.NPCPrefab, transform);
            _currentNPCPrefab.GetComponent<NPCEvent>().Setup(encounterData);
        }

        private void FinishEvent()
        {
            Destroy(_currentNPCPrefab);
            gameObject.SetActive(false);
        }
    }
}