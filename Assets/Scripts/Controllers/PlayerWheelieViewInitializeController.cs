using UnityEngine;
using UnityEngine.UI;


namespace DataSakuraBikeRace
{
    public sealed class PlayerWheelieViewInitializeController
    {
        private PoolContext _poolContext;

        public PlayerWheelieViewInitializeController(PoolContext poolContext)
        {
            _poolContext = poolContext;
            _poolContext.WheelieText = GameObject.Find("Wheelie Text").GetComponent<Text>();
        }
    }
}
