using UnityEngine;

public class RandomColor
{
    public Color GetRandomColor(Material material)
    {
        Color oldColor = material.color;
        Color newColor = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));

        if(oldColor == newColor) return GetRandomColor(material);

        return newColor;
    }
}
