using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairHandler : MonoBehaviour
{
    public Transform player;
    public Transform crosshair;

    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Pega a posi��o do mouse na tela
        Vector3 mousePosTela = Input.mousePosition;

        // Garante que o mouse n�o saia da tela
        mousePosTela.x = Mathf.Clamp(mousePosTela.x, 0, Screen.width);
        mousePosTela.y = Mathf.Clamp(mousePosTela.y, 0, Screen.height);

        // Converte a posi��o do mouse para o mundo
        Vector3 mousePosMundo = Camera.main.ScreenToWorldPoint(mousePosTela);
        mousePosMundo.z = 0; // Z = 0 para 2D (evita que a mira suba ou des�a no eixo Z)

        // Define a posi��o da mira
        crosshair.position = mousePosMundo;

        // Calcula o �ngulo da mira em rela��o ao jogador
        Vector3 direcaoMira = mousePosMundo - player.position;
        angle = Mathf.Atan2(direcaoMira.y, direcaoMira.x) * Mathf.Rad2Deg - 90f;
    }
}
