using System.Collections.Generic;


namespace DataSakuraBikeRace
{
    public sealed class MainControllers : IUpdatable, ITearDownable
    {
        #region Fields

        private readonly List<IUpdatable> _updatableControllers;
        private readonly List<ITearDownable> _tearDownables;

        #endregion


        #region ClassLifeCycle

        public MainControllers()
        {
            _updatableControllers = new List<IUpdatable>();
            _tearDownables = new List<ITearDownable>();
        }

        #endregion


        #region Methods

        public void Add(IControllerable controller)
        {
            if (controller is IUpdatable updatableController)
            {
                _updatableControllers.Add(updatableController);
            }

            if (controller is ITearDownable tearDownController)
            {
                _tearDownables.Add(tearDownController);
            }
        }

        #endregion


        #region IUpdatable

        public void Updating()
        {
            for (var index = 0; index < _updatableControllers.Count; index++)
            {
                _updatableControllers[index].Updating();
            }
        }

        #endregion


        #region ITearDownable

        public void TearDown()
        {
            for (var index = 0; index < _tearDownables.Count; index++)
            {
                _tearDownables[index].TearDown();
            }
        }

        #endregion        
    }
}
