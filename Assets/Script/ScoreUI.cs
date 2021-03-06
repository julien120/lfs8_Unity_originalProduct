﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public static int steakCount;
    public Text steakUI;
    public Text rankCountUI;
   public static int rank = 99000;

    // Start is called before the first frame update
    void Start()
    {
       DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        steakUI.text = "肉マイレージ数：" + steakCount.ToString("f0") + "g";
        rank = (int)(99000-steakCount*0.45);
        rankCountUI.text = "肉マイレージ総合ランキング：" + rank + "位";

    }

    
}
