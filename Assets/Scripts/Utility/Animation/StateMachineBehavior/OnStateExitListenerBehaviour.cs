using UnityEngine;
using UnityEngine.Events;

namespace Deviloop
{
    public class OnStateExitListenerBehaviour : StateMachineBehaviour
    {
        [SerializeField] private UnityEvent _onStateExit;
        
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            _onStateExit?.Invoke();
        }
    }
}
