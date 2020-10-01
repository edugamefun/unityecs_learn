/*
 Animator >state hero_run_01 > Parameter Set Cycle Offset=anim_run_offset
 */
using UnityEngine;

public class Animator_System : MonoBehaviour
{
    public Animator m_Animator;
    private float m_RunCycleOffseetMin = 0.0f;
    private float m_RunCycleOffseetMax = 1.0f;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (m_Animator != null)
        //    {
        //        float a = UnityEngine.Random.Range(m_RunCycleOffseetMin, m_RunCycleOffseetMax);

        //        m_Animator.Play("hero_run_01", 0, a);
        //        Debug.Log(Time.time + "play run start:" + a);
        //    }
        //    else
        //    {
        //        Debug.LogError("m_Animator is null");
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.F1))
        //{
        //    if (m_Animator != null)
        //    {

        //        m_Animator.Play("hero_run_01");
        //        Debug.Log(Time.time + "play run start:");
        //    }
        //    else
        //    {
        //        Debug.LogError("m_Animator is null");
        //    }
        //}

        //if(Input.GetKeyDown(KeyCode.A))
        //{

        //    float a = UnityEngine.Random.Range(m_RunCycleOffseetMin, m_RunCycleOffseetMax);
        //    //m_Animator.SetFloat("anim_run_offset", a);

        //    m_Animator.Play("hero_run_01", 0, a);
        //    //m_Animator.SetTrigger("trigger_1");
        //}


        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    float a = 0.0f;
        //    m_Animator.SetFloat("anim_run_offset", a);

        //    m_Animator.SetTrigger("trigger_1");

        //}
    }
}
