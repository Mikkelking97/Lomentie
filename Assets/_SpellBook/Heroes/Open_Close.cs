using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Open_Close : MonoBehaviour
{
  public Button hero_image;
  public Image hero_frame;

    // Start is called before the first frame update
    void Start()
    {
      
      Debug.Log("WHERE IS MY DAMN INTELISENSE?!");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

  public void Butonpress()
  {
    hero_frame.enabled = true;
  }

}
