using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject); // Destr�i o objeto quando ele sair da tela
    }
}
