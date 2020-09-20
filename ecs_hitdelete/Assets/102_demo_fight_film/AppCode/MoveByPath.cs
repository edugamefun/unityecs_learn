using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByPath : MonoBehaviour
{
    public Transform[] ways1;//路径点的位置
    public Transform target;//移动的物体
    private int index1;
    public float speed = 10.0f;
    public bool isRun = false;
    void Start()
    {
        //ways1 = JieLine.instance.LuJing;
        index1 = 0;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            isRun = true;
        }

        if(isRun)
        {
            MoveToway1();
        }
    }

    public void MoveToway1()
    {
        if (index1 > ways1.Length - 1)
        { 
            return; 
        }

        if(target.gameObject.activeSelf == false)
        {
            return;
        }

        target.localPosition = Vector3.MoveTowards(target.localPosition, ways1[index1].localPosition, speed * Time.deltaTime);
        if (Vector3.Distance(ways1[index1].localPosition, target.localPosition) < 0.01f)
        {
            index1++;

            if (index1 == ways1.Length)
            {
                target.localPosition = ways1[index1 - 1].localPosition;
            }
        }
    }
}