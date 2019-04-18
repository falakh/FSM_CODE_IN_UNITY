using UnityEngine;

namespace Transisi
{
    public class NoEnemyTransition : FSMtransition
    {
        private void Start()
        {
            transition = targetStateID.ToString();
        }
        public override void doInTransition()
        {
            Debug.Log("NO ENEMY..");
        }
    }
}