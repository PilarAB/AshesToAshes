﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderQueue : MonoBehaviour {
    //[Tooltip("Background=1000, Geometry=2000, AlphaTest=2450, Transparent=3000, Overlay=4000")]
    public int queue;

    //public int[] queues;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.sharedMaterial.renderQueue = queue;

        /*
         if (!renderer || !renderer.sharedMaterial || queues == null)
            return;
        renderer.sharedMaterial.renderQueue = queue;
        for (int i = 0; i < queues.Length && i < renderer.sharedMaterials.Length; i++)
            renderer.sharedMaterials[i].renderQueue = queues[i];
            */
    }

}