using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransAman : FSMtransition {

    public void Start()
    {
        transition = "Dead";
    }

    public override void doInTransition()
    {
        Debug.Log("Meninggal");
    }
}
