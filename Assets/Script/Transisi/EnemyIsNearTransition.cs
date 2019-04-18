using UnityEngine;

namespace Transisi
{
    public class EnemyIsNearTransition : FSMtransition
    {
        private void Start()
        {
            transition = targetStateID.ToString();
        }

        public override void doInTransition()
        {
            Debug.Log("Transisi Enemy is Near");
        }
    }
}