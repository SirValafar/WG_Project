﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaDamage : MonoBehaviour
{
    public LogicaBarraVida logicaBarraVidaJugador;

    public float pdamage = 2.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            logicaBarraVidaJugador.vidaActual -= pdamage;
        }
    }
}
