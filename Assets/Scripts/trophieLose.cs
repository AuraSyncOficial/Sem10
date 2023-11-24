using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophieLose : MonoBehaviour
{
    void Awake()
    {
        Trophies.TryUnlock(216227);
    }
}

