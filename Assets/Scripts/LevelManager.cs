using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public enum Levels { Menu = 0, Level101 = 1 };

    public void ChangeLevel(Levels level)
    {
        SceneManager.LoadScene((int)level);   //Función de SceneManager para cambiar la escena, se debe asignar cual
    }

    public void ChangeLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<LevelManager>().ChangeLevel(LevelManager.Levels.Menu);
    }
}
