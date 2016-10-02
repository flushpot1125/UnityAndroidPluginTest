using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestObject1 : MonoBehaviour {

[SerializeField]
private Text text;


	public void callStaticFunction(){
		AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
		AndroidJavaClass plugin = new AndroidJavaClass("moduletest.test.com.nativeplugin.NativeMethod");
		plugin.CallStatic("staticFunction");
	}

		public void onCallBackShowResult(string resultText){
		text.text = resultText;
	}

	
}
