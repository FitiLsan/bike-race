using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class PlayerModel
    {
        #region Fields

        private PlayerData _playerData;
        private Transform _transform;
        private Rigidbody2D _rearWheelRigidbody;
        private Rigidbody2D _frontWheelRigidbody;
        private WheelStateBehaviour _rearStateBehaviour;
        private WheelStateBehaviour _frontStateBehaviour;

        private float _distanceTraveled;
        private Vector3 _startPosition;

        #endregion


        #region ClassLifeCycles

        public PlayerModel(Transform transform, PlayerData playerData)
        {
            _startPosition = transform.position;
            _playerData = playerData;
            _transform = transform;

            _rearWheelRigidbody = _transform.Find("Rear Wheel").GetComponent<Rigidbody2D>();
            _rearStateBehaviour = _rearWheelRigidbody.GetComponent<WheelStateBehaviour>();
            _frontWheelRigidbody = _transform.Find("Front Wheel").GetComponent<Rigidbody2D>();
            _frontStateBehaviour = _frontWheelRigidbody.GetComponent<WheelStateBehaviour>();
        }

        #endregion


        #region Methods

        public void ApplyVelocity(MoveState moveState)
        {
            switch (moveState)
            {
                case MoveState.None:
                    {
                        return;
                    }
                case MoveState.Backward:
                    {
                        Braking();
                        break;
                    }
                case MoveState.Forward:
                    {
                        Accelerating();
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
        }

        private void Accelerating()
        {
            _rearWheelRigidbody.AddTorque(CalculateSpeed(-1), ForceMode2D.Force);
        }

        private void Braking()
        {
            _rearWheelRigidbody.AddTorque(CalculateSpeed(1), ForceMode2D.Force);
        }

        private float CalculateSpeed(float directionSpeed)
        {
            float maxSpeed = _playerData.MaxSpeed;
            float acceleration = _playerData.AccelerationSpeed * directionSpeed * Time.deltaTime;
            float speed = Mathf.Abs(_rearWheelRigidbody.angularVelocity) < maxSpeed ? acceleration : 0;

            return speed;
        }

        public Vector3 GetPlayerPosition()
        {
            return _transform.position;
        }

        public float GetDistanceTraveled()
        {
            var distanceVector = _startPosition - _transform.position;
            _distanceTraveled = distanceVector.magnitude;

            return _distanceTraveled;
        }

        public GameObject GetPlayerObject()
        {
            return _transform.gameObject;
        }

        public WheelState GetRearWheelState()
        {
            return _rearStateBehaviour.GetWheelState();
        }

        public WheelState GetFrontWheelState()
        {
            return _frontStateBehaviour.GetWheelState();
        }

        #endregion
    }
}
