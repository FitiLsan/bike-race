using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class CameraInitializeController
    {
        public CameraInitializeController(PoolContext poolContext)
        {
            var camera = Camera.main;
            poolContext.CameraModel = new CameraModel(poolContext, camera);
        }
    }
}
