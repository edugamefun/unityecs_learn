using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTargetPositionManager : MonoBehaviour
{
    public int XCount = 8;
    public int ZCount = 8;
    public int OffsetX = 5;
    public int OffsetZ = 5;
    public Transform m_Parent;
    public GameObject m_TargetPrefab;
    public Vector3 m_TargetScale = new Vector3(1, 1, 1);
    public int m_TargetDistZ = 50;
    public List<Transform> m_TargetList = new List<Transform>();

    // Start is called before the first frame update
    void Awake()
    {
        CreateTarget();
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
}
