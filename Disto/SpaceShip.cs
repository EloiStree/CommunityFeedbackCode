using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public interface Targetable {

    public void GetPosition( out Vector3 positionInWorld);

}

public abstract class AbstractTargetable :MonoBehaviour, Targetable
{
    public abstract void GetPosition(out Vector3 positionInWorld);
}

