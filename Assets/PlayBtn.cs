using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtn : MonoBehaviour
{
    public void PlayBtnClick()
    {
        SceneManager.LoadScene(1);
        
    }
}
