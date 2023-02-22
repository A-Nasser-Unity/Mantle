using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System;
using TMPro;
using UnityEngine.UI;

public class AutoWalletConnect : MonoBehaviour
{
    private void Start()
    {
        OnConnect();
    }

    public async void OnConnect()
    {
        try
        {
            await ThirdwebManager.Instance.SDK.wallet.Connect(
               new WalletConnection()
               {
                   provider = WalletProvider.MetaMask,
                   chainId = (int)ThirdwebManager.Instance.chain,
               });
            print($"Connected successfully");
        }
        catch (Exception e)
        {
            print($"Error Connecting Wallet: {e.Message}");
        }
    }
}
