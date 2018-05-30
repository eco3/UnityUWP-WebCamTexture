using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    public RawImage webcamImage;

    private WebCamTexture webCamTexture;

    private IEnumerator Start()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone);

        if (Application.HasUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone))
        {
            webCamTexture = new WebCamTexture();
            webcamImage.texture = webCamTexture;
            webcamImage.material.mainTexture = webCamTexture;

            webCamTexture.Play();
        }
    }
}