using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoleSoliderTag : MonoBehaviour
{
    public AIDestinationSetter m_Target;
    public int m_IndexX = 0;
    public int m_IndexZ = 0;
    public int m_TargetIndex = 0;

    private int m_LifeTimeMin = 15;
    private int m_LifeTimeMax = 25;

    private void Start()
    {
        Destroy(gameObject, UnityEngine.Random.Range(m_LifeTimeMin, m_LifeTimeMax));
    }
}
