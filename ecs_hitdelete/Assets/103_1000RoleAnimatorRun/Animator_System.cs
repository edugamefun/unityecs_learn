/*
 Animator >state hero_run_01 > Parameter Set Cycle Offset=anim_run_offset
 */
using UnityEngine;

public class Animator_System : MonoBehaviour
{
    public Animator Animator;
    private float m_RunCycleOffseetMin = 0.0f;
    private float m_RunCycleOffseetMax = 1.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {

            float a = UnityEngine.Random.Range(m_RunCycleOffseetMin, m_RunCycleOffseetMax);
            Animator.SetFloat("anim_run_offset", a);

            Animator.SetTrigger("trigger_1");
        }

 
        if (Input.GetKeyDown(KeyCode.D))
        {
            float a = 0.0f;
            Animator.SetFloat("anim_run_offset", a);

            Animator.SetTrigger("trigger_1");

        }
    }
}
