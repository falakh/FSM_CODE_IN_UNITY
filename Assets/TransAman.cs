using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpetyHealth : FSMtransition {

    public void Start()
    {
        transition = "aman";
    }

    public override void doInTransition()
    {
        Debug.Log("Meninggal");
    }
}
