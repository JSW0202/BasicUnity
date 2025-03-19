using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

[Serializable]
public class TextSwitcherBehaviour : PlayableBehaviour
{
    public Color color = Color.black;
    public int fontSize = 14;
    public string text;
}
