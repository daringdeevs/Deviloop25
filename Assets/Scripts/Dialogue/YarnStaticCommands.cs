using System.Linq;
using UnityEngine;
using Yarn.Unity;

namespace Deviloop
{
    public class YarnStaticCommands
    {
        [YarnCommand("add_item_to_deck")]
        public static void AddItemToDeck(string itemGUID)
        {
            Debug.Log($"Yarn: adding item to deck {itemGUID}");
            BaseCard cardToAdd = GameDataBaseManager.GameDatabase.cards.FirstOrDefault(card => card.GUID == itemGUID);

            if (!cardToAdd)
            {
                Debug.LogError($"Yarn: couldn't find the item to add to the deck, {itemGUID}");
                return;
            }
            
            CardManager.AddCardToDeckAction?.Invoke(cardToAdd, 1);
        }
    }
}