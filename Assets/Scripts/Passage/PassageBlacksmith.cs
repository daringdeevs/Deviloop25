using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Deviloop
{
    public class PassageBlacksmith : MonoBehaviour
    {
        [SerializeField] private GameObject _buttonPrefab;
        [SerializeField] private Transform _buttonCanvas;
        [SerializeField] private BaseCard _seahorseCard;

        private void OnEnable()
        {
            // TODO: more generic implementation for the quest cards
            int seaHorseCount = CardManager.NumberOfCardsInDeck(_seahorseCard);
            Debug.Log("player has " +  seaHorseCount + " seahorse cards in deck");
            
            if (seaHorseCount > 0)
            {
                int coinPerSeahorse = 50;
                var button = Instantiate(
                    _buttonPrefab, _buttonCanvas);
                button.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0.7f);
                button.GetComponentInChildren<TMP_Text>().text =
                    "return seahorses and get x" + seaHorseCount * coinPerSeahorse + " coins";
                button.GetComponent<Button>().onClick.AddListener(() =>
                {
                    PlayerInventory.CoinCount += (seaHorseCount * coinPerSeahorse);
                    CardManager.RemoveAllCardsOfTypeFromDeckAction(_seahorseCard, true);
                    button.SetActive(false);
                });
            }
        }
    }
}