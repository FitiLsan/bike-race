using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class PlayerInitializeController
    {
        #region ClassLifeCycles

        public PlayerInitializeController(PlayerData playerData, Vector3 spawnPosition, PoolContext poolContext)
        {
            var playerObject = Object.Instantiate(playerData.PlayerObject, spawnPosition, Quaternion.identity);

            PlayerModel playerModel = new PlayerModel(playerObject.transform, playerData);
            poolContext.PlayerModel = playerModel;
        }

        #endregion
    }
}
