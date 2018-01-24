﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleFlipAcademy : Academy
{
    public float MaxDistance;
    public float MinScale;
    public bool IsRandomDirection;

    public override void AcademyReset()
    {
        MaxDistance = resetParameters["max_distance"];
        MinScale = resetParameters["min_scale"];
        IsRandomDirection = !(resetParameters["min_scale"] > 0);
        Debug.Log($"AcademyReset: MaxDistance[{MaxDistance}];\t MinScale[{MinScale}];\t IsRandomDirection[{IsRandomDirection}]");
    }

    public override void AcademyStep()
    {
    }
}