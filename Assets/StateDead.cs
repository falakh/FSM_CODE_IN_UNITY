using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateDead : FSMState
{
    //public bool isAdaMusuh= false;
    public FSMSystem BaseFSMsystem;
    public Text result;
    

    public StateDead()
    {
        stateID = StateID.Dead;
    }

    public override void Act( GameObject npc)
    {
        result.text = "Meninggal";
    }

    public override void Reason( GameObject npc)
    {
    
    }


}
