using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class PlayerInputController : IUpdatable
    {
        private PoolContext _gameContext;
        private float _middleSceenPoint;

        #region ClassLifeCycle

        public PlayerInputController(PoolContext poolContext)
        {
            _gameContext = poolContext;
            _middleSceenPoint = Screen.width / 2;
        }

        #endregion


        #region IUpdatable

        public void Updating()
        {
            //#if UNITY_ANDROID

            if (Input.touchCount > 0)
            {
                Vector2 touchPosition = Input.GetTouch(0).position;
                Debug.Log(touchPosition);

                MoveState moveState = MoveState.None;
                if (touchPosition.x > _middleSceenPoint) moveState = MoveState.Forward;
                if (touchPosition.x < _middleSceenPoint) moveState = MoveState.Backward;

                _gameContext.PlayerModel.ApplyVelocity(moveState);
            }

            //#endif


            //#if UNITY_EDITOR

            //float speed = Input.GetAxis("Horizontal");

            //if (Mathf.Abs(speed) > 0)
            //{
            //    MoveState moveState = MoveState.None;
            //    if (speed > 0) moveState = MoveState.Forward;
            //    if (speed < 0) moveState = MoveState.Backward;

            //    _gameContext.PlayerModel.ApplyVelocity(moveState);
            //}


            //#endif
        }
        #endregion
    }
}