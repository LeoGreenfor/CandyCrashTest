using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;
using UnityEngine.SceneManagement;
using TMPro;

public class DataCollection : MonoBehaviour, IAppsFlyerConversionData
{
    [SerializeField]
    private TMP_Text text;

    public void onAppOpenAttribution(string attributionData)
    {
        AppsFlyer.AFLog("onAppOpenAttribution", attributionData);
        Dictionary<string, object> attributionDataDictionary = AppsFlyer.CallbackStringToDictionary(attributionData);
        foreach (KeyValuePair<string, object> kvp in attributionDataDictionary)
        {
            Debug.Log(kvp.Key + ": " + kvp.Value);
        }
    }

    public void onAppOpenAttributionFailure(string error)
    {
        AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
        Debug.Log("onAppOpenAttributionFailure");
        Debug.Log(error);
    }

    public void onConversionDataFail(string error)
    {
        AppsFlyer.AFLog("onConversionDataFail", error);
        Debug.Log("onConversionDataFail");
        Debug.Log(error);
    }

    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
        Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
        foreach (KeyValuePair<string, object> kvp in conversionDataDictionary)
        {
            text.text += kvp.Key + ": " + kvp.Value;
            Debug.Log(kvp.Key + ": " + kvp.Value);
        }
    }

    void Start()
    {
        AppsFlyer.initSDK("jamdJvHJjDz7FD89J2dZrc", "com.rocketraffic.unity.test", this);
        AppsFlyer.startSDK();
    }

}
