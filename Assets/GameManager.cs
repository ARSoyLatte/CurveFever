using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void EndGame(){
        StartCoroutine(PlayEndGameAnimation());
    }

    IEnumerator PlayEndGameAnimation(){
        Debug.Log("Game Over");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainScene");
    }
}
