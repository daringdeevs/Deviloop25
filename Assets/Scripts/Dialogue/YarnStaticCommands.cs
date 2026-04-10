using System.Linq;
using UnityEngine;
using Yarn.Unity;

namespace Deviloop
{
    public class YarnStaticCommands
    {
        [YarnCommand("add_item_to_deck")]
        public static void AddItemToDeck(string itemGUID, int count = 1)
        {
            Debug.Log($"Yarn: adding item to deck {itemGUID}");
            BaseCard cardToAdd = GameDataBaseManager.GameDatabase.cards.FirstOrDefault(card => card.GUID == itemGUID);

            if (!cardToAdd)
            {
                Debug.LogError($"Yarn: couldn't find the item to add to the deck, {itemGUID}");
                return;
            }
            
            CardManager.AddCardToDeckAction?.Invoke(cardToAdd, count);
        }
        
        [YarnCommand("deal_damage_to_player")]
        public static void DealDamageToThePlayer(int damage = 1)
        {
            Player.PlayerCombatCharacter.TakeDamage(damage, AttackType.Normal);
        }
                
        [YarnCommand("add_coin_to_player")]
        public static void AddCoinToThePlayer(int coin)
        {                    
            PlayerInventory.CoinCount += coin;
        }
    }
}