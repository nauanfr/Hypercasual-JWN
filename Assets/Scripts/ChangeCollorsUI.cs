using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCollorsUI : MonoBehaviour
{
    public Image corAtual;
    public Image corAnterior;
    public Image corSeguinte;

    private Color[] colors = { Color.red, Color.green, Color.blue };
    private int currentIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUIColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentIndex = (currentIndex + 1) % colors.Length;
            UpdateUIColor();
        }
    }

    void UpdateUIColor()
    {
        // Cor Atual  � sempre a cor atual
        corAtual.color = colors[currentIndex];

        // Cor Anterior � a cor anterior � cor atual
        int previousIndex = (currentIndex - 1 + colors.Length) % colors.Length;
        corAnterior.color = colors[previousIndex];

        // Cor Seguinte � a pr�xima cor ap�s a cor atual
        int nextIndex = (currentIndex + 1) % colors.Length;
        corSeguinte.color = colors[nextIndex];
    }
}
