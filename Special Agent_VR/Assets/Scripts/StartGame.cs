using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   
   void Update() {
      if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.Space)) {
          SceneManager.LoadScene(1);
      }
   }

}
