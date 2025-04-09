using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoopBackground : MonoBehaviour
{
    public float BackgroundSpeed;
    public Renderer BackgroundRenderer;
    void Update()
    {
        BackgroundRenderer.material.mainTextureOffset+= new Vector2(BackgroundSpeed*Time.deltaTime,0f);
        
    }
}
