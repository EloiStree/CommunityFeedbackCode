using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Vincent_Reposition : MonoBehaviour
{

    public Transform m_camera;
    public Transform m_normal;

    public Vector3 localNormalDirection;
    public Vector3 localPointRelocated;


    public float m_angleLocal;
    public float m_dotResult;

    public float m_pointAngle;
    public float m_pointDot;

    public float m_maxAngle=70;

    public int m_count = 0;
    public A m_countWrapper;
    public A m_countWrapperRef;
    [System.Serializable]
    public class A {
        public int m_count=0;
    }

    public void Increment(in int countToUpdate) {
       // countToUpdate++; // Not allow
    }

    public void Increment(in A wrapperInt)
    {
        //wrapperInt = new A(); // Not allow
        wrapperInt.m_count++; // Allow but ...
    }
    public void IncrementRef(ref A wrapperInt)
    {
        Eloi.E_UnityRandomUtility.GetRandom_n180_180(out float randomValeur);
       // wrapperInt = new A() { m_count = (int)randomValeur }; // Allow but ...
        wrapperInt = new A() { m_count = wrapperInt.m_count+1 }; // Allow but ...
    }


    void Update()
    {
        Increment(in m_countWrapper);
        IncrementRef(ref m_countWrapperRef);
        Vector3 c = m_camera.position;
        Quaternion q = m_camera.rotation;

        Eloi.E_DrawingUtility.DrawCartesianOrigine(in c, in q, 10,0.1f );

        //IS DIRECTION FORWARDING TE CAMERA
        Eloi.E_DrawingUtility.ComeOnVincent(m_normal, m_camera
           , Color.red+Color.blue, Time.deltaTime);


        m_angleLocal= Vector3.Angle(Vector3.forward, localNormalDirection);
        m_dotResult = Vector3.Dot(Vector3.forward, localNormalDirection);


        /// IS IT IN ANGLE OF CAMERA
        Vector3 normalState = m_normal.position;

        Eloi.E_RelocationUtility.GetWorldToLocal_Point(in normalState, in   m_camera, out localPointRelocated);

        m_pointAngle = Vector3.Angle(Vector3.forward, localPointRelocated);
        m_pointDot = Vector3.Dot(Vector3.forward, localPointRelocated.normalized);
        m_normal.gameObject.SetActive(m_pointAngle < m_maxAngle);



     


    }
}
