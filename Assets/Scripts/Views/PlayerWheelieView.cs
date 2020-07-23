namespace DataSakuraBikeRace
{
    public sealed class PlayerWheelieView : IUpdatable
    {
        #region Fields

        private PoolContext _poolContext;
        private string _displayText = "Wheelie!";

        #endregion   


        #region ClassLifeCycle

        public PlayerWheelieView(PoolContext poolContext)
        {
            _poolContext = poolContext;
            _poolContext.WheelieText.text = _displayText;
        }

        #endregion   


        #region Methods

        public void ViewDistanceText()
        {
            if (_poolContext.WheelieDetectorModel.WheelieState == WheelieState.Wheelie)
            {
                _poolContext.WheelieText.gameObject.SetActive(true);
            }
            else _poolContext.WheelieText.gameObject.SetActive(false);
        }

        #endregion   


        #region IUpdatable 

        public void Updating()
        {
            ViewDistanceText();
        }

        #endregion
    }
}
