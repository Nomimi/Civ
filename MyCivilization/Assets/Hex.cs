using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex {

    //q+r+s =0
    //s = -(q+r)

    public readonly int q; //Collumn 
    public readonly int r; //Row 
    public readonly int s; // 
    float radius = 1f;


    static readonly float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;
    public Hex(int q, int r)
    {
        this.q = q;
        this.r = r;
        this.s = -(q + r);

    }

    //Returns Hex Position
    public Vector3 Position() {

        float verticalSpacing = HexHeight() * 0.75f;
        float horizontalSpacing = HexWidth();

        return new Vector3(
            horizontalSpacing * (this.q + this.r / 2f),
            0,
            verticalSpacing * this.r
         );
    }

    public float HexHeight()
    {
        return radius * 2;
    }

    public float HexWidth()
    {
        return WIDTH_MULTIPLIER * HexHeight();
    }
    public float HexVerticalSpacing()
    {
        return HexHeight() * 0.75f;
    }

    public float HexHorizontalSpacing()
    {
        return HexWidth();
    }
    public Vector3 PositionFromCamera(Vector3 cameraPosition, float numRows, float numColumns)
    {

        float mapHeight = numRows * HexVerticalSpacing();
        float mapWidth = numColumns * HexHorizontalSpacing();
        Vector3 position = Position();

        float howManyWidthFromCamera = (position.x - cameraPosition.x) / mapWidth;

        if(Mathf.Abs(howManyWidthFromCamera) <= 0.5f)
        {
            return position;
        }

        if (howManyWidthFromCamera > 0)
        { howManyWidthFromCamera += 0.5f; }
        else
        {
            howManyWidthFromCamera -= 0.5f;
        }

        int howManyWidthToFix = (int)howManyWidthFromCamera;
        return position;
    }


}
