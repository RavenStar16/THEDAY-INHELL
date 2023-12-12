using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsManager : MonoBehaviour
{
    public int maxHearts = 3;
    public int currentHearts;
    public GameObject Heart;

    private void Start()
    {
        currentHearts = maxHearts;
    }

    public void LoseHeart()
    {
        if (currentHearts > 0)
        {
            currentHearts--;
            Destroy(Heart);
        }
    }
}
