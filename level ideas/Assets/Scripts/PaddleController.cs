using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private bool PLAY = true;
    [SerializeField] private GameObject Player;
    [SerializeField] private bool IsPlayerOne;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PLAY)
        {
            if (IsPlayerOne)
            {

            }
        }
    }
}
