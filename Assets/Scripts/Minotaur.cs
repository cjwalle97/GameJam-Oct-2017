using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Minotaur")]

public class Minotaur : ScriptableObject
{
    public string TargetTag { get; set; }
    public float Speed { get; set; }
}
