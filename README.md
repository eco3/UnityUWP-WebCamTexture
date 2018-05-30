# UnityUWP-WebCamTexture
Simple Unity scene to demonstrate a UWP bug involving WebCamTexture.

[This simple scene](Assets/Scene.unity) has a Canvas and a RawImage.
Another GameObject contains a [script](Assets/Scripts/WebCam.cs) which uses [Unity's WebCamTexture](https://docs.unity3d.com/ScriptReference/WebCamTexture.html) and displays it on the RawImage.

Running this scene in the editor works out fine.
However compiling and running it as a UWP-Application it shows following error messages:

![Error output](misc/webcamtexture_unity_error.png)

Translation from German to English:

> Error: Operation has failed with error 0x80028019: Old format or invalid type library.
