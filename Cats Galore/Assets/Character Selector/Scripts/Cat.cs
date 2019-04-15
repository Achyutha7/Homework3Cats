using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Material[] furColor;
    public Material[] eyeColor;
    public GameObject body;
    public GameObject rightEye;
    public GameObject leftEye;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        int colorIndex = (int)(Random.value * 3);
        RenderCube(body, colorIndex, furColor);

        colorIndex = (int)(Random.value * 3);
        RenderCube(rightEye, colorIndex, eyeColor);
        RenderCube(leftEye, colorIndex, eyeColor);
    }

    // Update is called once per frame
    private void RenderCube(GameObject obj, int colorIndex, Material[] color)
    {
        rend = obj.GetComponent<Renderer>();
        rend.enabled = true;

        rend.sharedMaterial = color[colorIndex];
    }
}
