using TMPro;
using UnityEngine;

public class InstructionPage : MonoBehaviour
{

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void ClickedOnStart(bool isClicked)
    {
        if (isClicked)
            Time.timeScale = 1.0f;
    }
}
