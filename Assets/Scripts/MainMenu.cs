using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Tanks
{
    public class MainMenu : MonoBehaviourPunCallbacks
    {
        static MainMenu instance;

        private GameObject ui;
        private Button joinGameButton;

        void Awake()
        {
            if (instance != null)
            {
                DestroyImmediate(gameObject);
                return;
            }
            instance = this;
            ui = transform.FindAnyChild<Transform>("UI").gameObject;
            joinGameButton = transform.FindAnyChild<Button>("JoinGameButton");
            ui.SetActive(true);
            joinGameButton.interactable = false;
        }
        public override void OnConnectedToMaster()
        {
            joinGameButton.interactable = true;
        }

        public override void OnEnable()
        {
            // Always call the base to add callbacks
            base.OnEnable();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        public override void OnDisable()
        {
            // Always call the base to remove callbacks
            base.OnDisable();
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            ui.SetActive(!PhotonNetwork.InRoom);
        }
    }

    
}
