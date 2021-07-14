using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestWizard : Wizard
{
    // POLYMORPHISM
    public override void Initialize()
    {
        robeColor = Resources.Load("Forest", typeof(Material)) as Material;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).CompareTag("Clothes"))
            {
                transform.GetChild(i).gameObject.GetComponent<Renderer>().material = robeColor;
            }
        }

        Health = 500;
        MaxMana = 150;
        ManaCosts = 10;
        Damage = 50;
        type = DamageType.Forest;
    }
}