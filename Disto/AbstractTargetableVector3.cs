using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class AbstractTargetableVector3 : AbstractTargetable
{

    public Vector3 m_positionInWorld;
    public override void GetPosition(out Vector3 positionInWorld)
    {
        positionInWorld = m_positionInWorld;
    }
}