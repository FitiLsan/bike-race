using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class WheelStateBehaviour : MonoBehaviour
    {
        [SerializeField] private WheelState _wheelState;

        #region UnityMethods

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.layer == LayerManager.LandLayer)
            {
                _wheelState = WheelState.OnLand;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerManager.LandLayer) 
            {
                _wheelState = WheelState.InAir;
            }
        }

        #endregion


        #region Methods

        public WheelState GetWheelState()
        {
            return _wheelState;
        }

        #endregion
    }
}
