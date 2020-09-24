using UnityEngine;
using UnityEngine.Playables;

/// <summary>
/// 拖拽到Hierarchy > SignalReceive GameObject
/// 也能接收到 Add Signal Emitter 的消息, SignalEmitterSoliderFight is null error
/// </summary>
public class SignalReceive_FightEvent : MonoBehaviour,INotificationReceiver
{
    public PlayableDirector PlayableDirector;
    public PlayableAsset PlayableAsset;
    private double a;
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        SignalEmitterSoliderFight gm = notification as SignalEmitterSoliderFight;
        if (gm != null)
        {
            if(gm.m_ID == 1)
            {
                a = PlayableDirector.time;
                PlayableDirector.playableGraph.GetRootPlayable(0).SetSpeed(0d);
                Invoke("PlayGo", 4);
            }
            Debug.Log(gm.speed);
        }
    }

    void PlayGo()
    {

        //PlayableDirector.initialTime = a + 4;
        PlayableDirector.playableGraph.GetRootPlayable(0).SetSpeed(1d);
        Debug.Log("Play:" + Time.time);
    }
}
//activeDirector.playableGraph.GetRootPlayable(0).SetSpeed(0d);