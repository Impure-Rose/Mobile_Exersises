using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class buttonScript : MonoBehaviour
{
    [SerializeField] private Text textField;

    public void YellowPressed()
    {
        textField.text = "You clicked yellow button";

    }
    public void RedPressed()
    {
        textField.text = "You clicked red button";
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
