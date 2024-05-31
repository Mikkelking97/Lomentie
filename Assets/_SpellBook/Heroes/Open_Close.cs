using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Open_Close : MonoBehaviour
{
  //The button that will turn a image on/off.
  [Tooltip("Assign the button that wil turn an image on or off.")]
  public Button button;
  /*[Tooltip("The image that will be turned on/off by the button.")]
  public Image image;*/
public GameObject test;

    // Start is called before the first frame update
    void Start()
    {
      //image.enabled = false;
      test.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

  public void Butonpress()
  {
    /*if(image.enabled == false)
    {
      image.enabled = true;
    }
    else
    {
      image.enabled = false;
    }*/

    if(test.activeInHierarchy)
    {
      test.SetActive(false);
    }
    else
    {
      test.SetActive(true);
    }

  }

}
