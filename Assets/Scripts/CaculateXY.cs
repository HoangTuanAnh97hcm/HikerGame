using UnityEngine;

public class CaculateXY
{
    public static Vector2 CaculateXYOfObject(float v, float a, float t)
    {
        float s = v * t;
        return new Vector2(Mathf.Cos(a) * s, Mathf.Sin(a) * s);
    }
}
