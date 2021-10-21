using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCannon : MonoBehaviour
{
    public TargetTaskBase m_target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


[System.Serializable]
public class TargetTaskBase
{
    public enum IAState
    {
        None,
        Stand,
        Patrol,
        Move,
        Follow
    }
    public IAState state;
    [SerializeReference]
    public AbstractTargetable target;
    public bool isCompleted;
}


