namespace DataSakuraBikeRace
{
    public sealed class AllControllersInitialozator
    {
        #region ClassLifeCycle

        public AllControllersInitialozator(PlayerData playerData, PoolContext poolContext, 
            MainControllers updateController, LevelGeneratorData levelGeneratorData)
        {            
            Initializers(playerData, poolContext, levelGeneratorData);
            Controllers(poolContext, updateController);
        }

        #endregion


        #region Methods

        private void Initializers(PlayerData playerData, PoolContext poolContext, LevelGeneratorData levelGeneratorData)
        {
            new PlayerInitializeController(playerData, poolContext.PlayerStartPosition, poolContext);
            new LevelGeneratorInitializeController(poolContext, levelGeneratorData);
            new CameraInitializeController(poolContext);
            new WheelieDetectorInitializeController(poolContext);
            new PlayerDistanceViewInitializeContoller(poolContext);
            new PlayerWheelieViewInitializeController(poolContext);
        }

        private void Controllers(PoolContext poolContext, MainControllers updateController)
        {
            updateController.Add(new PlayerInputController(poolContext));
            updateController.Add(new LevelGeneratorController(poolContext));
            updateController.Add(new CameraController(poolContext));
            updateController.Add(new WheelieDetectorController(poolContext));
            updateController.Add(new PlayerDistanceView(poolContext));
            updateController.Add(new PlayerWheelieView(poolContext));
            updateController.Add(new RestartGameEventController(poolContext));
        }

        #endregion
    }
}
