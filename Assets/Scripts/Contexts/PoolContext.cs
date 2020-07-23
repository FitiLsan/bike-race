using UnityEngine;
using UnityEngine.UI;


namespace DataSakuraBikeRace
{
    public sealed class PoolContext
    {
        #region Fields

        public PlayerModel PlayerModel;
        public LevelGeneratorModel LevelGeneratorModel;
        public CameraModel CameraModel;
        public WheelieDetectorModel WheelieDetectorModel;

        public Text WheelieText;
        public Text DistanceText;

        public Vector3 PlayerStartPosition = Vector3.zero;

        #endregion


        #region ClassLifeCycle

        public PoolContext(Vector3 position)
        {
            PlayerStartPosition = position;
        }

        #endregion
    }
}
