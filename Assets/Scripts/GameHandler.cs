using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static int playerStat1;
        // public TMP_Text textGameObject;

        // void Start () { UpdateScore (); }

        void Update(){
        //NOTE: This quit functionality should not be needed:
                // if (Input.GetKey("escape")){
                //         Application.Quit();
                // }

                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}
        }

        // void UpdateScore () {
        //        textGameObject.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Inicio");
        }

        public void OpenPause(){
                SceneManager.LoadScene("PausaMenu");
        }

        public void MainMenu(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MenuInicio");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
} 
