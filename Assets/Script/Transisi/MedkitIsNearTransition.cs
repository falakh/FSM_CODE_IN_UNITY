using UnityEngine;

namespace Transisi
{
    public class MedkitIsNearTransition : FSMtransition
    {
        private void Start()
        {
            transition = targetStateID.ToString();
        }
        public override void doInTransition()
        {
            Debug.Log("Medkit Found");
        }
    }
}