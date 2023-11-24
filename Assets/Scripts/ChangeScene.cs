using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void ChangeSc(string Name)
    {
        SceneManager.LoadScene(Name);
    }

    public void MostrarTrofeos()
    {
        GameJoltUI.Instance.ShowTrophies();
    }
}