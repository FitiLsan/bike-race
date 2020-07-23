using UnityEngine;

namespace DataSakuraBikeRace
{
    [CreateAssetMenu(fileName = "LevelGeneratorData", menuName = "Data/LevelGeneratorData")]
    public class LevelGeneratorData : ScriptableObject
    {
        #region Fields

        public GameObject GeneratorObject;
        public Vector4 MinMaxGeneratingXY = new Vector4(1.0f, 5.0f, 1.0f, 5.0f);
        public float GeneratedDistance = 5f;
        public float TerrainOfsset = 0.175f;

        #endregion
    }
}