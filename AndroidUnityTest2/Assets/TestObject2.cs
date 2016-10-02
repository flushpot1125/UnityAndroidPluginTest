using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TestObject2 : MonoBehaviour {

[SerializeField]
private Text text;


	public void callNonStaticFunction(){
		AndroidJavaObject plugin = new AndroidJavaObject("moduletest.test.com.nativeplugin.NativeMethod");
		plugin.Call("nonStaticFunction");

	}
		public void onCallBackShowResult(string resultText){
		text.text = resultText;
	}
}
