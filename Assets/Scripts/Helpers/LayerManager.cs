using UnityEngine;


namespace DataSakuraBikeRace
{
    public static class LayerManager
    {
        #region Fields

        private const string LAND = "Land";
        private const string DEFAULT = "Default";

        #endregion


        #region Proeprties

        public static int DefaultLayer { get; }
        public static int LandLayer { get; }      

        #endregion


        #region Class lifecycle

        static LayerManager()
        {
           
            DefaultLayer = LayerMask.NameToLayer(DEFAULT);
            LandLayer = LayerMask.NameToLayer(LAND);
        }

        #endregion
    }
}
