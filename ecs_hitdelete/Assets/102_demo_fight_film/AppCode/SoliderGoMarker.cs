using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

/// <summary>
/// customize signal emitter, Timeline right > add
/// </summary>
public class SignalEmitterSoliderFight: Marker,INotification
{
    public float speed;

    public PropertyName id
    {
        get
        {
            return new PropertyName();
        }
    }

    
}
