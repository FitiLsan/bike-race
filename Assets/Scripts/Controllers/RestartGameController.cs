using UnityEngine.SceneManagement;


namespace DataSakuraBikeRace
{
    public sealed class RestartGameEventController : ITearDownable
    {
        private SteeringWheelCollisionBehaviour _steeringWheelCollisionBehaviour;

        #region ClassLifeCycle

        public RestartGameEventController(PoolContext poolContext)
        {
            var collisionBehaviour = 
                poolContext.PlayerModel.GetPlayerObject().GetComponent<SteeringWheelCollisionBehaviour>();

            _steeringWheelCollisionBehaviour = collisionBehaviour;
            _steeringWheelCollisionBehaviour.OnCollisionEnterHandler += OnCollisionEnterHandler;
        }

        #endregion


        #region Methods

        private void OnCollisionEnterHandler()
        {
            RestartGame();
        }
        
        private void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        #endregion


        #region ITearDownable

        public void TearDown()
        {
            _steeringWheelCollisionBehaviour.OnCollisionEnterHandler -= OnCollisionEnterHandler;
        }

        #endregion
    }
}
