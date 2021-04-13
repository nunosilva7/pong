using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreKeeper : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;

    [SerializeField]
    TextMeshProUGUI leftScoreTxt;

    [SerializeField]
    TextMeshProUGUI rightScoreTxt;

    public void Goal(wall.WallName collision )
    {
        if(collision == wall.WallName.Right)
        {
            leftScore++;
        }
        else if(collision == wall.WallName.Left)
        {
            rightScore++;
        }

        leftScoreTxt.text = leftScore.ToString();
        rightScoreTxt.text = rightScore.ToString();

        Debug.Log(leftScore + "-" + rightScore);
         
    }
 }
