using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Deviloop
{
    public enum DamageType
    {
        Normal,
        Critical,
        Heal,
        Shield
    }

    public class DamageIndicator : MonoBehaviour, IPoolable
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Animator _animator;
        [SerializeField] private DamageTypeSettings[] _damageTypeSettings;

        private CancellationTokenSource cts = new CancellationTokenSource();

        [System.Serializable]
        public struct DamageTypeSettings
        {
            public Color _color;
            public DamageType _damageType;
        }

        public void Setup(int amount, float destroyAfter, DamageType damageType)
        {
            _text.color = System.Array.Find(_damageTypeSettings, setting => setting._damageType == damageType)._color;

            _text.text = amount.ToString();
            if (destroyAfter <= 0)
            {
                destroyAfter = 1f;
            }
            else
            {
                _animator.speed = 1f / destroyAfter;

            }
            
            cts = new CancellationTokenSource();
            DestroyDamageIndicator(destroyAfter);
        }

        private async UniTask DestroyDamageIndicator(float destroyAfter)
        {
            await Awaitable.WaitForSecondsAsync(destroyAfter).WithCancellation(cts.Token);
            PoolManager.Instance.GetPool(this).ReturnToPool(this);
        }

        public void OnSpawned()
        {
        }

        public void OnDespawned()
        {
            cts.Cancel();
        }
    }
}
