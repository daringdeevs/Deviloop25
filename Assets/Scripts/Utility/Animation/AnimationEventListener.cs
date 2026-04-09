using UnityEngine;
using UnityEngine.Events;

namespace Deviloop
{
    public class AnimationEventListener : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onAnimationEnd;

        public void OnAnimationEnd()
        {
            _onAnimationEnd?.Invoke();
        } 
    }
}
