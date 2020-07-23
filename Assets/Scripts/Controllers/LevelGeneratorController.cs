namespace DataSakuraBikeRace
{
    public sealed class LevelGeneratorController : IUpdatable
    {
        private PoolContext _poolContext;

        public LevelGeneratorController(PoolContext poolContext)
        {
            _poolContext = poolContext;
        }

        public void Updating()
        {
            _poolContext.LevelGeneratorModel.GenerateLocation();
        }
    }
}
