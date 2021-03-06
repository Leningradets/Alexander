using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class God : MonoBehaviour
{ 
    [SerializeField] protected struct _coordinates
    {
        int X;
        int Y;
    }

    public virtual void Move()
    {

    }
}
