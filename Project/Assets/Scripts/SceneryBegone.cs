using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryBegone : MonoBehaviour
{
    [SerializeField] GameObject selectedScenery;
    [SerializeField] CameraControl CC;
    private void FixedUpdate()
    {
        if (CC.camPos >= 3 || CC.camPos <= -3)
        {
            Debug.Log("rize");
            selectedScenery.SetActive(true);
        }
        else
        {
            Debug.Log("fall");
            selectedScenery.SetActive(false);
        }
    }
}
