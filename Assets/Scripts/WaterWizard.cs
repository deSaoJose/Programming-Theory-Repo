using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWizard : Wizard
{
    // POLYMORPHISM
    public override void Initialize()
    {
        robeColor = Resources.Load("Water", typeof(Material)) as Material;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).CompareTag("Clothes"))
            {
                transform.GetChild(i).gameObject.GetComponent<Renderer>().material = robeColor;
            }
        }

        Health = 100;
        MaxMana = 600;
        ManaCosts = 60;
        Damage = 120;
        type = DamageType.Water;
    }
}