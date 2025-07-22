using UnityEngine;

namespace Chapter.State
{

    public class BikeTurnState : MonoBehaviour, IBikeState
    {
        private Vector3 _turnDirection;
        private BikeController _bikeController;

        void IBikeState.Handle(BikeController bikeController)
        {
            if(!_bikeController)
                _bikeController = bikeController;

            _turnDirection.x = (float)_bikeController.CurrentTurnDirection;
            
            if(_bikeController.CurrentSpeed > 0)
            {
                _bikeController.transform.Translate(_turnDirection * _bikeController.turnDistance);
            }
        }
    }
}
