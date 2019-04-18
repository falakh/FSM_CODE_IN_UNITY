using Entity;
using UnityEngine;
using UnityEngine.UI;

namespace State
{
    public class HuntState : FSMState
    {
        private FSMSystem BaseFSMsystem;
        public Text result;

        private void OnEnable()
        {
            BaseFSMsystem = GetComponent<FSMSystem>();
            stateID = StateID.Hunt;
        }

        public override void Reason(GameObject npc)
        {
            var data = npc.GetComponent<PlayerEntity>();
            if (!data.isEnemyNear)
            {
                BaseFSMsystem.PerformTransition(transitions[0]);
            }else if (data.medkitIsNear)
            {
                BaseFSMsystem.PerformTransition(transitions[1]);
            }else if (data.badKitIsNear)
            {
                BaseFSMsystem.PerformTransition(transitions[2]);
            }else if (data.badKitIsNear)
            {
                BaseFSMsystem.PerformTransition(transitions[3]);
            }  
        }

        public override void Act(GameObject npc)
        {
            result.text = "Hunting...";
        }
    }
}