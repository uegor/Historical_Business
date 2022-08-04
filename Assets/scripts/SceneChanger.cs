using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public void to_game()
    {
        SceneManager.LoadScene(1);
    }

    public void to_inf0()
    {
        SceneManager.LoadScene(2);
    }

    public void to_action()
    {
        SceneManager.LoadScene(3);
    }

    public void to_historia()
    {
        SceneManager.LoadScene(4);
    }
}
