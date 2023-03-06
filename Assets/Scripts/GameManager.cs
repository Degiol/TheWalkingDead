using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    private GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        //No destruir al cambiar de escena
        DontDestroyOnLoad(gameManager);

        cambiarEscena("SampleScene1");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarEscena(string siguienteEscena)
    {
        SceneManager.LoadScene(siguienteEscena);
    }
}
