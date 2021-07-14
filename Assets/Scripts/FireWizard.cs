using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWizard : Wizard
{
    // POLYMORPHISM
    public override void Initialize()
    {
        robeColor = Resources.Load("Fire", typeof(Material)) as Material;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).CompareTag("Clothes"))
            {
                transform.GetChild(i).gameObject.GetComponent<Renderer>().material = robeColor;
            }
        }

        Health = 200;
        MaxMana = 300;
        ManaCosts = 40;
        Damage = 70;
        type = DamageType.Fire;
    }
}
