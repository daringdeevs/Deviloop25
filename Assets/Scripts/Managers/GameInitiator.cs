using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Deviloop
{
    public class GameInitiator : MonoBehaviour
    {
        private async void Start()
        {
            await DoSth();
        }

        private async UniTask DoSth()
        {
            
        }
    }
}
