namespace DataSakuraBikeRace
{
    public sealed class CameraController : IUpdatable
    {
        private PoolContext _poolContext;

        public CameraController(PoolContext poolContext)
        {
            _poolContext = poolContext;
        }

        public void Updating()
        {
            _poolContext.CameraModel.MoveToPlayer();
        }
    }
}
