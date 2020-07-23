using UnityEngine;


namespace DataSakuraBikeRace
{
    public class MainBehaviour : MonoBehaviour
    {
        #region Fields

        [SerializeField] private PlayerData _playerData;
        [SerializeField] private LevelGeneratorData _levelGeneratorData;
        [SerializeField] private Transform _playerStartPosition;

        private MainControllers _mainController;

        #endregion


        #region UnityMethods

        private void Start()
        {
            PoolContext poolContext = new PoolContext(_playerStartPosition.position);
            _mainController = new MainControllers();

            new AllControllersInitialozator(_playerData, poolContext, _mainController, _levelGeneratorData);
        }

        private void Update()
        {
            _mainController.Updating();
        }

        private void OnDestroy()
        {
            _mainController.TearDown();
        }

        #endregion
    }
}