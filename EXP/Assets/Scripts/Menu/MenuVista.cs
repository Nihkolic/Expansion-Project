using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVista : MonoBehaviour
{
    public MenuControlador controlador;
    public void BCambioDeEscena(int index)
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

    public void Volver()
    {
        controlador.Back();
    }
}
