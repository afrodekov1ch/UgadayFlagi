using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    
    
}