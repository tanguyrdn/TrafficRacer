using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeScript : MonoBehaviour
{
    [SerializeField]
    protected int CurrentLife;

    protected int MaxLife;

    private void Start()
    {
        MaxLife = CurrentLife;
    }

    public virtual void UpdateLife(int nb)
    {
        CurrentLife += nb;

        if (CurrentLife <= 0)
        {
            Death();
        }
    }

    public abstract void Death();

    public abstract void End();
  
}
