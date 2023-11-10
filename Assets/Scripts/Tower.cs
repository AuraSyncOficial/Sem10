using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour, ITower
{
    public abstract void Attack();
}

public class BasicTower : Tower
{
    public override void Attack()
    {
        // L�gica de ataque b�sico
    }
}

public class SniperTower : Tower
{
    public override void Attack()
    {
        // L�gica de ataque de francotirador
    }
}