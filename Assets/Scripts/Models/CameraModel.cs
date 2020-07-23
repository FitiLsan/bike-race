using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class CameraModel
    {
        #region Fields

        private readonly PoolContext _poolContext;
        private readonly Camera _mainCamera;

        #endregion


        #region ClassLifeCycle

        public CameraModel(PoolContext poolContext, Camera mainCamera)
        {
            _mainCamera = mainCamera;
            _poolContext = poolContext;
        }

        #endregion  


        #region Methods

        public void MoveToPlayer()
        {
            var cameraPosition = _mainCamera.transform.position;
            var playerPosition = _poolContext.PlayerModel.GetPlayerPosition();
            
            var newCameraPosition = InterpolatePosition(cameraPosition, playerPosition, 0.6f);
            _mainCamera.transform.position = newCameraPosition;
        }

        private Vector3 InterpolatePosition(Vector3 cameraPosition, Vector3 player, float lerpValue)
        {
            Vector3 newPosition = Vector3.zero;

            newPosition.x = Mathf.Lerp(cameraPosition.x, player.x, lerpValue);
            newPosition.y = Mathf.Lerp(cameraPosition.y, player.y, lerpValue);
            newPosition.z = cameraPosition.z;

            return newPosition;
        }

        #endregion 
    }
}
