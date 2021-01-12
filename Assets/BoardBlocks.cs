using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoardBlocks : MonoBehaviour
{

    public Button button;
    public Text buttonText;

    private GC gameController;

    public void SetGameControllerReference(GC controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }
}