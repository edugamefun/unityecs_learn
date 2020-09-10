using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateSolider_Manager : MonoBehaviour
{
    public AttackTargetPositionManager m_AttackTarget;
    public int XCount = 5;
    public int ZCount = 5;
    public int OffsetX = 5;
    public int OffsetZ = 5;
    public Transform m_Parent;
    public GameRoleSoliderTag m_PrefabSolider;
    public int SoliderCount = 0;
    public GameObject m_ObstaclePrefab;
    public Vector3 m_ObstacleScale = new Vector3(1, 1, 10);

    public GameObject m_TargetPrefab;
    public Vector3 m_TargetScale = new Vector3(1, 1, 1);
    public int m_TargetDistZ = 50;
    public List<Transform> m_TargetList = new List<Transform>();

    void Start()
    {
        //CreateTarget();

        CreateGO();
        CreateObstacleX();
        CreateObstacleZ();
    }

    private void CreateTarget()
    {
        m_TargetList.Clear();

        for (int z = 0; z < ZCount; z++)
        {
            var g = GameObject.Instantiate(m_TargetPrefab);
            g.transform.SetParent(m_Parent, false);
            g.transform.localPosition = new Vector3(z * OffsetZ, 0, m_TargetDistZ);
            g.transform.localScale = m_TargetScale;
            //
            m_TargetList.Add(g.transform);
        }
    }

    private void CreateObstacleZ()
    {
        for (int z = 0; z < (ZCount + 1); z++)
        {
            CreateObstacleGO(z);
        }
    }

    private void CreateObstacleGO(int z)
    {
        var g = GameObject.Instantiate(m_ObstaclePrefab);
        g.transform.SetParent(m_Parent, false);
        g.transform.localPosition = new Vector3(z * OffsetZ - OffsetZ*0.5f, 0, 0);
        g.transform.localScale = m_ObstacleScale;
    }

    private void CreateObstacleX()
    {

    }

    private void CreateGO()
    {
        for(int x=0;x < XCount;x++)
        {
            for (int z = 0; z < ZCount; z++)
            {
                CreateSolider(x,z);
                SoliderCount = SoliderCount + 1;
            }
        }

    }

    private void CreateSolider(int x,int z)
    {
        var g = GameObject.Instantiate<GameRoleSoliderTag>(m_PrefabSolider);
        g.transform.SetParent(m_Parent, false);
        g.transform.localPosition = new Vector3(x * OffsetX, 0, z * OffsetZ);
        //
        g.m_IndexX = x;
        g.m_IndexZ = z;
        //

        g.m_TargetIndex = x;

        g.m_Target.target = m_AttackTarget.m_TargetList[g.m_TargetIndex];
    }
}
