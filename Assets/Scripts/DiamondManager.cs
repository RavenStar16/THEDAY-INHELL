using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondManager : MonoBehaviour
{
    public int diamondCount;
    public Text diamondText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diamondText.text = "Diamond Count: " + diamondCount.ToString();
    }
}
