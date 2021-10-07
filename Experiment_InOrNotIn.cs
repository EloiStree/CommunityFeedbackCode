using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Experiment_InOrNotIn : MonoBehaviour
{
     public Transform []myVar;
    public int m_iteration=1000000;
    

    public string m_withoutIn;
    public string m_withIn;

    // Start is called before the first frame update
    void Start()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        for (int i = 0; i < m_iteration; i++)
        {
            Increment(myVar[0].position);
        }
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
        m_withoutIn = elapsedTime;


         stopWatch = new Stopwatch();
        stopWatch.Start();

         Vector3 p = myVar[0].position;
        for (int i = 0; i < m_iteration; i++)
        {
            Increment(in p);
        }
        stopWatch.Stop();
         ts = stopWatch.Elapsed;
         elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
        m_withIn = elapsedTime;

    }

    private void Increment(in Vector3 myProperty)
    {
        Vector3 v = myProperty*2f;
    }

  
}
