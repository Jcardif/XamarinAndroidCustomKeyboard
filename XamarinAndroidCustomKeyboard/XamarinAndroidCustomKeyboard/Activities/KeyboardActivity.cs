using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.InputMethodServices;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace XamarinAndroidCustomKeyboard.Activities
{
    [Activity(MainLauncher = true)]

    [Service(Permission = "anroid.permission.BIND_INPUT_METHOD", Label = "JCardif Keyboard")]
    [MetaData("android.view.im", Resource = "@xml/method")]
    [IntentFilter(new string[] {"android.view.InputMethod"})]
    public class KeyboardActivity : InputMethodService, KeyboardView.IOnKeyboardActionListener
    {
        private KeyboardView view;
        private Keyboard keyboard;
        private bool isCaps = false;

        public override View OnCreateInputView()
        {
            view = (KeyboardView) LayoutInflater.Inflate(Resource.Layout.keyboardLayout, null);
            keyboard = new Keyboard(this, Resource.Xml.Qwerty);
            view.Keyboard = keyboard;
            view.OnKeyboardActionListener = this;
            return view;
        }

        public void OnKey([GeneratedEnum] Android.Views.Keycode primaryCode, [GeneratedEnum] Android.Views.Keycode[] keyCodes)
        {
           
        }

        public void OnPress([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
            
        }

        public void OnRelease([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
           
        }

        public void OnText(ICharSequence text)
        {
            
        }

        public void SwipeDown()
        {
           
        }

        public void SwipeLeft()
        {
            
        }

        public void SwipeRight()
        {
           
        }

        public void SwipeUp()
        {
            
        }


    }
}