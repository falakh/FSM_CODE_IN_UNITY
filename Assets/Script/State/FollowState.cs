using Entity;
using UnityEngine;
using UnityEngine.UI;

namespace State
{
    [RequireComponent(typeof(FSMSystem))]
    public class FollowState : FSMState
    {
        
        private FSMSystem BaseFSMsystem;
        public Text result;

        private void OnEnable()
        {
            BaseFSMsystem = GetComponent<FSMSystem>();
            stateID = StateID.Folow;
        }

        public override void Reason(GameObject npc)
        {
            var data = npc.GetComponent<PlayerEntity>();
            if (data != null)
            {
              
                if (data.medkitIsNear)
                {
                    BaseFSMsystem.PerformTransition(transitions[0]);
                }else if (data.isEnemyNear)
                {
                    BaseFSMsystem.PerformTransition(transitions[1]);
                }else if (data.badKitIsNear)
                {
                    BaseFSMsystem.PerformTransition(transitions[2]);
                }                
            }
          
        }

        public override void Act(GameObject npc)
        {
            result.text = "Follow";
        }
    }
}