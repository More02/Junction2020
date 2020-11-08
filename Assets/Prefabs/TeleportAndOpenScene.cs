using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportAndOpenScene : MonoBehaviour
{
    public string sceneToLoad;

    public void MovePlayerAndOpenScene()
    {
        Player.SetPosition(transform.position);
        SceneManager.LoadScene(sceneToLoad);
    }
}
