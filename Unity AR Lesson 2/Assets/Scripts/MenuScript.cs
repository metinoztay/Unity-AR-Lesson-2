using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void RotateCubeScene()
    {
        SceneManager.LoadScene("RotateCubeScene");
    }
    public void SphereFallScene()
    {
        SceneManager.LoadScene("SphereFallScene");
    }
}
