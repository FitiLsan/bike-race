using System;
using UnityEngine;


namespace DataSakuraBikeRace
{
    public class SteeringWheelCollisionBehaviour : MonoBehaviour, ICollisionable
    {
        public Action OnCollisionEnterHandler { get; set; }

        #region UnityMethods

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == LayerManager.LandLayer)
            {
                OnCollisionEnterHandler.Invoke();
            }
        }

        #endregion
    }
}
