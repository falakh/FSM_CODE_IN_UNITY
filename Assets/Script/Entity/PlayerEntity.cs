using UnityEngine;

namespace Entity
{
    [RequireComponent(typeof(FSMSystem))]
    public class PlayerEntity : MonoBehaviour
    {
        public bool badKitIsNear;
        public bool isEnemyNear;
        public bool medkitIsNear;
        private  FSMSystem _FSMsystem;
        public bool noItemNear;

        private void OnEnable()
        {
            _FSMsystem = GetComponent<FSMSystem>();
        }

        void Update () {

            _FSMsystem.currentState.Reason(this.gameObject);
            _FSMsystem.currentState.Act(this.gameObject);

        }
    }
}