using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using OpenfortSdk;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    [Header("UI Buttons")] 
    public Button getPlayerButton;
    public Button createPlayerButton;
    public Button createAccountButton;
    public Button getInventoryButton;

    [SerializeField]
    private string playerId = "pla_23485465-03c0-4716-b235-e2580ee10d9e";
    
    private void Start()
    {
        // Set Openfort keys
        Openfort.PublishedKey = Config.PublishedKey;
        Openfort.SecretKey = Config.SecretKey;
    }

    private void OnEnable()
    {
        getPlayerButton.onClick.AddListener(() => GetPlayer());
        createPlayerButton.onClick.AddListener(() => CreatePlayer());
        createAccountButton.onClick.AddListener(() => CreateAccount());
        getInventoryButton.onClick.AddListener(() => GetInventory());
    }

    private void OnDisable()
    {
        
    }
    
    private async UniTaskVoid GetPlayer()
    {
        var response = await Openfort.PlayersApi.GetPlayer(playerId);

        Debug.Log(response);
    }
    
    private async UniTaskVoid CreateAccount()
    {
        AccountRequest accountRequest = new AccountRequest(playerId, 5);
        var response = await Openfort.AccountsApi.CreateAccount(accountRequest);

        Debug.Log(response);
    }

    private async UniTaskVoid CreatePlayer()
    {
        PlayerRequest pr = new PlayerRequest();
        
        //var response = await Openfort.PlayersApi.CreatePlayerAccount();
        
        //Debug.Log(response);
    }
    
    private async UniTaskVoid GetInventory()
    {
        var response = await Openfort.PlayersApi.GetPlayerInventory(playerId);
        
        Debug.Log(response);
    }
}
