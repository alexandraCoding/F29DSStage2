using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Proyecto26;
using Models;
using UnityEditor;

public class AzureDataAccessor : IDataAccessor
{

   

    public void GetItem<T>(IDataReceiver dataReceiver, string url)
    {
        ///////////////excersizemvvmwebapi.azurewebsites.net/people
        //////https://excersizemvvmwebapi.azurewebsites.net/
        RestClient.Request(new RequestHelper
            {  
                Method = "GET", 
                Uri = "http://localhost:11919/" + url
        }).Then(res =>
            {
                var item = JsonConvert.DeserializeObject<T>(res.Text);
                dataReceiver.ReceiveData<T>(item);

            }).Catch(err =>
            {
                var error = err as RequestException;
                Debug.LogError(error);
            });

       
        }

   

    public void SaveItem<T>(object item, string url)
    {
        var itemToSave = JsonConvert.SerializeObject(item);
       
       
        RestClient.Put<T>("http://localhost:11919/" + url, itemToSave).Then(customResponse =>
        {
            //JsonUtility.ToJson(customResponse, true);
            Debug.Log("object" + itemToSave);
        });



     
    }

   



}
