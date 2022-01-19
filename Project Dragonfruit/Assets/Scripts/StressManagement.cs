using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class StressManagement : MonoBehaviour
{

    public int strsslvl = 0;
    public TextMeshProUGUI Display;
    public static StressManagement Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Display.text = strsslvl.ToString();
    }
}
