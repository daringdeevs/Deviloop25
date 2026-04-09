using UnityEngine;
using UnityEngine.Events;

namespace Deviloop
{
    public class NPCVisualController : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onEnterAnimationEnd;
        [SerializeField] private UnityEvent _onExitAnimationEnd;
        
        public void OnEnterAnimationEnd()
        {
            _onEnterAnimationEnd?.Invoke();
        }
        
        public void OnExitAnimationEnd()
        {
            _onExitAnimationEnd?.Invoke();
        }
    }
}
