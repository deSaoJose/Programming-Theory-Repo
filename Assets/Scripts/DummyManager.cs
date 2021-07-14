using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyManager : MonoBehaviour
{
    private int health = 2000;

    // ABSTRACTION
    public void DealDamage(int damage, DamageType type)
    {
        health -= damage;
        switch(type)
        {
            case DamageType.Fire:
                ChangeColor(Color.red);
                break;
            case DamageType.Water:
                ChangeColor(Color.cyan);
                break;
            case DamageType.Electric:
                ChangeColor(Color.magenta);
                break;
            case DamageType.Forest:
                ChangeColor(Color.green);
                break;
        }
        Debug.Log("Dealt " + damage + " Damage to Dummy");
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void ChangeColor(Color color)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).CompareTag("Clothes"))
            {
                transform.GetChild(i).gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
            }
        }
        Debug.Log("Color chosen: " + color);
    }
}
