using UnityEngine;

namespace Transisi
{
    public class NoITemArraoundTransition : FSMtransition
    {
        private void Start()
        {
            transition = targetStateID.ToString();
        }
        public override void doInTransition()
        {
            Debug.Log("No Item Around");
        }
    }
}