using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryBegone : MonoBehaviour
{
    [SerializeField] GameObject selectedScenery;
    [SerializeField] float scenerySpeed;
    [SerializeField] CameraControl CC;
    // Start is called before the first frame update
    private void Update()
    {
        if (CC.camPos >= 2 || CC.camPos <= -2)
        {

        }
    }
}
