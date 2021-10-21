using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class AbstractTargetableTransform : AbstractTargetable
{
    public Transform m_positionInWorld;
    public override void GetPosition(out Vector3 positionInWorld)
    {

        positionInWorld = m_positionInWorld.position;
    }
}
