using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlaces {

    public float index;
    public bool isFree;
    public Color color;

    public BuildingPlaces(float newIndex, bool newisFree)
    {
        index = newIndex;
        isFree = newisFree;

        if (isFree)
            color = Color.green;
        else
            color = Color.red;
    }


}
