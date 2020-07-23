using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class WheelieDetectorController : IUpdatable
    {
        private PoolContext _poolContext;

        #region ClassLifeCycle

        public WheelieDetectorController(PoolContext poolContext)
        {
            _poolContext = poolContext;
            poolContext.WheelieDetectorModel.CurrentWheelieTimer 
                = poolContext.WheelieDetectorModel.StartWheelieTimer;
        }

        #endregion


        #region Methods

        private void DiscardWheelie()
        {
            _poolContext.WheelieDetectorModel.CurrentWheelieTimer = _poolContext.WheelieDetectorModel.StartWheelieTimer;
            _poolContext.WheelieDetectorModel.WheelieState = WheelieState.OnLand;
        }

        #endregion


        #region IUpdatable

        public void Updating()
        {
            var playerModel = _poolContext.PlayerModel;

            if (playerModel.GetFrontWheelState() == WheelState.InAir)
            {
                if (playerModel.GetRearWheelState() == WheelState.OnLand)
                {
                    if (_poolContext.WheelieDetectorModel.CurrentWheelieTimer > 0)
                        _poolContext.WheelieDetectorModel.CurrentWheelieTimer -= Time.deltaTime;
                    else
                        _poolContext.WheelieDetectorModel.WheelieState = WheelieState.Wheelie;
                }
                else DiscardWheelie();
            }
            else DiscardWheelie();      
        }

        #endregion       
    }
}
