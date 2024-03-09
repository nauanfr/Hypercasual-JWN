using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Color[] colors = { Color.red, Color.green, Color.blue };
    private int currentIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.material.color = colors[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentIndex = (currentIndex + 1) % colors.Length;
            meshRenderer.material.color = colors[currentIndex];
            Debug.Log("Clicou");
        }
    }
}
