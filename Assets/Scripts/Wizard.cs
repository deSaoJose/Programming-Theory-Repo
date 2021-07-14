using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public int Health
    {
        get;
        set;
    }

    public int MaxMana { get; protected set; }

    public int ManaCosts { get; protected set; }

    public DamageType type;

    protected int Damage;

    protected Material robeColor;

    public virtual void Initialize()
    {

    }

    // INHERITANCE
    public virtual void DealDamage()
    {
        if (!(MaxMana - ManaCosts < 0))
        {
            MaxMana -= ManaCosts;
            GameObject.Find("Dummy").GetComponent<DummyManager>().DealDamage(Damage, type);
        }

    }

    // INHERITANCE
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DealDamage();
        }
    }

    // INHERITANCE
    public void Start()
    {
        Initialize();
    }
}
