using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVista : MonoBehaviour
{
    public MainMenu controlador;
    public void BInicio(int index)
    {
        controlador.ChangeScene(index);
    }
    public void BCreditos()
    {
        controlador.Credits();
    }
    public void BSalir()
    {
        controlador.QuitGame();
    }
}
