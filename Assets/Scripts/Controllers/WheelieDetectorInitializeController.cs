namespace DataSakuraBikeRace
{
    public sealed class WheelieDetectorInitializeController
    {
        public WheelieDetectorInitializeController(PoolContext poolContext)
        {
            poolContext.WheelieDetectorModel = new WheelieDetectorModel();
        }
    }
}
