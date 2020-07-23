using UnityEngine;
using UnityEngine.UI;


namespace DataSakuraBikeRace
{
    public sealed class PlayerDistanceViewInitializeContoller
    {
        private PoolContext _poolContext;

        public PlayerDistanceViewInitializeContoller(PoolContext poolContext)
        {
            _poolContext = poolContext;

            _poolContext.DistanceText = GameObject.Find("Distance Text").GetComponent<Text>();
        }
    }
}
