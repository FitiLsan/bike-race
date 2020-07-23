using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class LevelGeneratorInitializeController
    {
        public LevelGeneratorInitializeController(PoolContext poolContext, LevelGeneratorData generatorData)
        {
            var generatorObject = Object.Instantiate(generatorData.GeneratorObject, Vector3.zero, Quaternion.identity);
            poolContext.LevelGeneratorModel = 
                new LevelGeneratorModel(generatorData, poolContext, generatorObject);
        }
    }
}
