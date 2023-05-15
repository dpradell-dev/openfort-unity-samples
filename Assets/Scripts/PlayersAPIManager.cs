using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using OpenfortSdk;
using UnityEngine.UI;

public class PlayersAPIManager : MonoBehaviour
{
    [SerializeField]
    private string playerId = "pla_23485465-03c0-4716-b235-e2580ee10d9e";
    [SerializeField]
    private string accountId = "acc_336b16e0-5fad-4311-8c00-0de2b8624cd4";

    [Header("UI")]
    public Transform responseContent;
    public ResponseLabel responseLabel;

    private void Start()
    {
        // Set Openfort keys
        Openfort.PublishedKey = Config.PublishedKey;
        Openfort.SecretKey = Config.SecretKey;
        
        //TODO Get endpoints from PlayersAPI and automatically create buttons
    }
    
    
    #region PUBLIC_ENDPOINT_CALLS

    public async void GetPlayers()
    {
        var response = await Openfort.PlayersApi.GetPlayers(playerId);

        foreach (var rsp in response.data)
        {
            var newResponseLabel = Instantiate(responseLabel, responseContent);
            newResponseLabel.SetText(rsp.ToString());
         
            Debug.Log(rsp);   
        }
    }
    
    public async void CreatePlayer()
    {
        PlayerRequest pr = new PlayerRequest("New player", "A new player");
        
        var response = await Openfort.PlayersApi.CreatePlayer(pr);
        
        var newResponseLabel = Instantiate(responseLabel, responseContent);
        newResponseLabel.SetText(response.ToString());
        
        Debug.Log(response);
    }

    public async void GetPlayer()
    {
        var response = await Openfort.PlayersApi.GetPlayer(playerId);

        var newResponseLabel = Instantiate(responseLabel, responseContent);
        newResponseLabel.SetText(response.ToString());
        
        Debug.Log(response);
    }
    
    public async void UpdatePlayer()
    {
        PlayerRequest pr = new PlayerRequest("David Pradell", "31 years old");

        var response = await Openfort.PlayersApi.UpdatePlayer(playerId, pr);

        var newResponseLabel = Instantiate(responseLabel, responseContent);
        newResponseLabel.SetText(response.ToString());
        
        Debug.Log(response);
    }

    public async void GetPlayerAccounts()
    {
        var response = await Openfort.PlayersApi.GetPlayerAccounts(playerId);

        foreach (var rsp in response.data)
        {
            var newResponseLabel = Instantiate(responseLabel, responseContent);
            newResponseLabel.SetText(rsp.ToString());
         
            Debug.Log(rsp);   
        }
    }

    #endregion

    
    #region PRIVATE_METHODS

    

    #endregion
}
