
using UnityEngine;
using UnityEngine.Localization;

public abstract class BaseEncounter : ScriptableObject
{
    //TODO: replace with localized string
    public LocalizedString EncounterName;
    public string EncounterDebugName;
    public Sprite EncounterIcon;
    public abstract void StartEncounter();
    public abstract void FinishEncounter();
    public virtual void ResetEncounter() { }
}
