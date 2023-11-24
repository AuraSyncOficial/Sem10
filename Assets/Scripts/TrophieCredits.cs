using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophieCredits : MonoBehaviour
{
    void Awake()
    {
        Trophies.TryUnlock(216230);
    }
}
