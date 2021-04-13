using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{

    public enum WallName { Left, Right};

    [SerializeField]
    scoreKeeper scoreKeeper;

    [SerializeField]
    WallName side = WallName.Left;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        scoreKeeper.Goal(side);
    }
}
