using Entity;
using UnityEngine;
using UnityEngine.UI;

namespace State
{
    public class CollectItemState : FSMState
    {
        private FSMSystem BaseFSMsystem;
        public Text result;

        private void OnEnable()
        {
            BaseFSMsystem = GetComponent<FSMSystem>();
            stateID = StateID.CollectItem;
        }
        public override void Reason(GameObject npc)
        {
            var player = npc.GetComponent<PlayerEntity>();
            if (player.noItemNear)
            {
                if (player.isEnemyNear)
                {
                    BaseFSMsystem.PerformTransition(transitions[0]);
                }
                else if(!player.isEnemyNear)
                {
                    BaseFSMsystem.PerformTransition(transitions[1]);
                }
            }
        }

        public override void Act(GameObject npc)
        {
            result.text = "Colect Item";
        }
    }
}