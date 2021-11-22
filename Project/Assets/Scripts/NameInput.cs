using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInput : MonoBehaviour
{
    //Public Objects

    public Image FirstRow;
    public Image SecondRow;
    public Image ThirdRow;

    public TextMeshProUGUI FirstLetter;
    public TextMeshProUGUI SecondLetter;
    public TextMeshProUGUI ThirdLetter;


    public TextMeshProUGUI PlayersName;

    int ActiveNumber;
    bool PlayerReady;

    List<string> Letters = new List<string>
    {
        "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z"
    };

    int index1;
    int index2;
    int index3;

    void Start()
    {
        ActiveNumber = 1;
        index1 = 0;
        index2 = 0;
        index3 = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("q"))
        {
            index1 = index1 + 1;
            if (index1 > 25 )
            {
                index1 = 0;

            }
            FirstLetter.text = Letters[index1];
        }
        {
            if (Input.GetKeyDown("a"))
            {
                index1 = index1 - 1;
                if (index1 < 0)
                {
                    index1 = 25;

                }

                FirstLetter.text = Letters[index1];
            }

        }
        if (Input.GetKeyUp("w"))
        {
            index2 = index2 + 1;
            if (index2 > 25)
            {
                index2 = 0;

            }
            SecondLetter.text = Letters[index2];
        }
        {
            if (Input.GetKeyDown("s"))
            {
                index2 = index2 - 1;
                if (index2 < 0)
                {
                    index2 = 25;

                }

                SecondLetter.text = Letters[index2];
            }

        }
        if (Input.GetKeyUp("e"))
        {
            index3 = index3 + 1;
            if (index3 > 25)
            {
                index3 = 0;

            }
            ThirdLetter.text = Letters[index3];
        }
        {
            if (Input.GetKeyDown("d"))
            {
                index3 = index3 - 1;
                if (index3 < 0)
                {
                    index3 = 25;

                }

                ThirdLetter.text = Letters[index3];
            }

        }




    }
}
