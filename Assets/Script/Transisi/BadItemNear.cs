using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Transisi
{
    public class BadItemNear :FSMtransition
    {
        private void Start()
        {
            transition = targetStateID.ToString();
        }

        public override void doInTransition()
        {
            Debug.Log("BAD ITEM FOUND");
        }
    }
}