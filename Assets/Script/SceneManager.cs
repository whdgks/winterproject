using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void SceneButton(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

}
