using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(keyRestart))
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetKey(keyRestart))
            SceneManager.LoadScene("MiniGame");
            //time = Time.timeSinceLevelLoad;
        //if (Input.GetKey(keyRestart))
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
