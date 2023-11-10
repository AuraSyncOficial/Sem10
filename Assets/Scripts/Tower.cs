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
        // Lógica de ataque básico
    }
}

public class SniperTower : Tower
{
    public override void Attack()
    {
        // Lógica de ataque de francotirador
    }
}