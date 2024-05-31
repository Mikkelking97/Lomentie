using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RealmChanger : MonoBehaviour
{
    public Button realmshiftbutton;
    public string destination;

    public void Changerealm()
    {
        SceneManager.LoadSceneAsync(destination, LoadSceneMode.Additive);
        Debug.Log("Reading...");
    }
}
