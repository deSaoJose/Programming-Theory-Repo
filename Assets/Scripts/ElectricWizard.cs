using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricWizard : Wizard
{
    // POLYMORPHISM
    public override void Initialize()
    {
        robeColor = Resources.Load("Electric", typeof(Material)) as Material;
        for(int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).CompareTag("Clothes"))
            {
                transform.GetChild(i).gameObject.GetComponent<Renderer>().material = robeColor;
            }
        }

        Health = 300;
        MaxMana = 200;
        ManaCosts = 50;
        Damage = 150;
        type = DamageType.Electric;
    }
}
