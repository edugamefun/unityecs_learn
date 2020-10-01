using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator_System_Offset : MonoBehaviour
{
    public Animator m_Animator;
    private float m_RunCycleOffseetMin = 0.0f;
    private float m_RunCycleOffseetMax = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            if (m_Animator != null)
            {
                float a = UnityEngine.Random.Range(m_RunCycleOffseetMin, m_RunCycleOffseetMax);
                m_Animator.SetFloat("anim_run_offset", a);

                m_Animator.SetTrigger("trigger_1");
            }
            else
            {
                Debug.LogError("m_Animator is null");
            }
        }
    }
}

/*
if (Input.GetKeyDown(KeyCode.F5))
{
    if (m_Animator != null)
    {
        float a = UnityEngine.Random.Range(m_RunCycleOffseetMin, m_RunCycleOffseetMax);

        m_Animator.Play("hero_run_01", 0, a);
        Debug.Log(Time.time + "play run start:" + a);
    }
    else
    {
        Debug.LogError("m_Animator is null");
    }
}
 */