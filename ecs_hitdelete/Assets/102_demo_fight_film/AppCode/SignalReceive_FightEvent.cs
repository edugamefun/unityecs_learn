using UnityEngine;
using UnityEngine.Playables;

/// <summary>
/// 拖拽到Hierarchy > SignalReceive GameObject
/// 也能接收到 Add Signal Emitter 的消息, SignalEmitterSoliderFight is null error
/// </summary>
public class SignalReceive_FightEvent : MonoBehaviour,INotificationReceiver
{
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        SignalEmitterSoliderFight gm = notification as SignalEmitterSoliderFight;
        if (gm != null)
        {
            Debug.Log(gm.speed);
        }
    }
}
