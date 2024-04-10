using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Verbal Tense", menuName = "Verbal Tense")]
public class VerbalTense : ScriptableObject
{
    public Tense tense;
    [TextArea(3, 5)] public string tenseDescription;
    public string[] auxiliaryVerbs;
    public string[] examples;
}

public enum Tense
{
    SimplePresent,
    PresentContinuous,
    SimplePast,
    PastContinuous,
    PresentPerfect,
    PastPerfect,
    PresentPerfectContinuous,
    PastPerfectContinuous,
    SimpleFuture,
    FutureContinuous,
    FuturePerfect,
    FuturePerfectContinuous
}