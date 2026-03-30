using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

namespace Deviloop.Cards.Animations
{
    [System.Serializable]
    public abstract class CardAnimationType
    {
        public bool _playWithNext;
        [SerializeField] protected ModifiableFloat _delayBeforeMove = new ModifiableFloat(.3f);
        [SerializeField] protected ModifiableFloat _delayAfterMove = new ModifiableFloat(.3f);

        public abstract UniTask Play(GameObject card, GameObject target = null);
    }

    [AddTypeMenu("MoveToTarget")]
    [System.Serializable]
    public class MoveToTarget : CardAnimationType
    {
        [SerializeField] private ModifiableFloat _moveDuration = new ModifiableFloat(.2f);

        public override async UniTask Play(GameObject card, GameObject target = null)
        {
            await Awaitable.WaitForSecondsAsync(_delayBeforeMove.Value);
            if (!card || !target) return;

            Tween tween = card.transform
                .DOMove(target ? target.transform.position : card.transform.position, _moveDuration.Value)
                .SetEase(Ease.Linear)
                .SetLink(target); // auto-kill if card dies

            await Awaitable.WaitForSecondsAsync(_delayAfterMove.Value);

            if (tween.active)
                await tween.AsyncWaitForCompletion();
        }
    }

    [AddTypeMenu("MoveToPlayerHP")]
    [System.Serializable]
    public class MoveToPlayer : CardAnimationType
    {
        [FormerlySerializedAs("MoveDuration")] [SerializeField] private ModifiableFloat _moveDuration = new ModifiableFloat(.2f);

        public override async UniTask Play(GameObject card, GameObject target = null)
        {
            Transform playerHpPos = Player.PlayerCombatCharacter.HPOrigin;

            await Awaitable.WaitForSecondsAsync(_delayBeforeMove.Value);
            if (!card || !target) return;

            Tween tween = card.transform
                .DOMove(playerHpPos.gameObject ? playerHpPos.position : card.transform.position, _moveDuration.Value)
                .SetEase(Ease.Linear)
                .SetLink(target); // auto-kill if target dies

            await Awaitable.WaitForSecondsAsync(_delayAfterMove.Value);

            if (tween.active)
                await tween.AsyncWaitForCompletion();
        }
    }


    [AddTypeMenu("MoveToPlayerShield")]
    [System.Serializable]
    public class MoveToPlayerShield : CardAnimationType
    {
        [SerializeField] private ModifiableFloat _moveDuration = new ModifiableFloat(.2f);

        public override async UniTask Play(GameObject card, GameObject target = null)
        {
            Transform playerShieldPos = Player.PlayerCombatCharacter.ShieldOrigin;

            await Awaitable.WaitForSecondsAsync(_delayBeforeMove.Value);
            if (!card || !target) return;

            Tween tween = card.transform
                .DOMove(playerShieldPos.gameObject ? playerShieldPos.position : card.transform.position, _moveDuration.Value)
                .SetEase(Ease.Linear)
                .SetLink(target); // auto-kill if target dies

            await Awaitable.WaitForSecondsAsync(_delayAfterMove.Value);

            if (tween.active)
                await tween.AsyncWaitForCompletion();
        }
    }


    [AddTypeMenu("ScaleAnimation")]
    [System.Serializable]
    public class ScaleAnimation : CardAnimationType
    {
        [SerializeField] private ModifiableFloat _scaleDuration = new ModifiableFloat(0.5f);
        [SerializeField] private float _targetScaleMult = 2;
        [SerializeField] private Ease _ease = Ease.OutBack;

        public override async UniTask Play(GameObject card, GameObject target = null)
        {
            await Awaitable.WaitForSecondsAsync(_delayBeforeMove.Value);
            if (!card || !target) return;

            Vector3 targetScale = card.transform.localScale * _targetScaleMult;

            Tween tween = card.transform
                .DOScale(targetScale, _scaleDuration.Value)
                .SetEase(_ease)
                .SetLink(target);

            if (!card || !target) return;

            await Awaitable.WaitForSecondsAsync(_delayAfterMove.Value);
        }
    }

    [AddTypeMenu("RotateAnimation")]
    [System.Serializable]
    public class RotateAnimation : CardAnimationType
    {
        [SerializeField] private ModifiableFloat _rotateDuration = new ModifiableFloat(.5f);
        [SerializeField] private float _rounds = 5;

        public override async UniTask Play(GameObject card, GameObject target = null)
        {
            await Awaitable.WaitForSecondsAsync(_delayBeforeMove.Value);

            Tween tween = card.transform
                .DORotate(new Vector3(0, 0, 360 * _rounds), _rotateDuration.Value, RotateMode.FastBeyond360)
                .SetEase(Ease.Linear)
                .SetLink(target);

            await Awaitable.WaitForSecondsAsync(_delayAfterMove.Value);

            if (tween.active)
                await tween.AsyncWaitForCompletion();
        }
    }
}
