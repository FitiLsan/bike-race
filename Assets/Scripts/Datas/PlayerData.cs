using UnityEngine;

namespace DataSakuraBikeRace
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        #region Fields

        public GameObject PlayerObject;
        public float MaxSpeed = 100.0f;
        public float AccelerationSpeed = 10.0f;
        public float MaxMotorTorque = 10000.0f;

        #endregion
    }
}