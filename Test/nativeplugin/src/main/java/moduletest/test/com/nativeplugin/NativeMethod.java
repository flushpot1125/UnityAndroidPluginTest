package moduletest.test.com.nativeplugin;

import android.util.Log;

import com.unity3d.player.UnityPlayer;

public class NativeMethod {

    public static void staticFunction(){
        Log.e("[Unity Test]","Static Method has been called!");
        UnityPlayer.UnitySendMessage("TestObject_Static","onCallBackShowResult","Static Method has been called!");
    }

    public void nonStaticFunction(){
        Log.e("[Unity Test]","Non static Method has been called!");
        UnityPlayer.UnitySendMessage("TestObject_NonStatic","onCallBackShowResult","Non static Method has been called!");
    }
}
