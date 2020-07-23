using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class PlayerDistanceView : IUpdatable
    {
        #region Fields

        private PoolContext _poolContext;
        private string _displayText = "Distance Traveled: ";

        #endregion   


        #region ClassLifeCycle

        public PlayerDistanceView(PoolContext poolContext)
        {
            _poolContext = poolContext;
        }

        #endregion


        #region Methods

        public void ViewDistanceText()
        {
            var distance = _poolContext.PlayerModel.GetDistanceTraveled();
            distance = Mathf.Round(distance);
            _poolContext.DistanceText.text = $"{_displayText} {distance}";
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
