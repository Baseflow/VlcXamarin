using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Org.Videolan.Libvlc;

namespace VlcXamarin.Sample
{
    [Activity (Label = "VlcXamarin.Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        LibVLCLibVLC mLibVLC = null;

        //LibVLC mLibVLC = null;
        MediaPlayer mMediaPlayer = null;

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            if(mLibVLC == null)
            {
                mLibVLC = new LibVLCLibVLC();
                mMediaPlayer = new MediaPlayer(mLibVLC);
            }

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button> (Resource.Id.myButton);

            button.Click += delegate {
                button.Text = string.Format ("{0} clicks!", count++);

                MediaLibVLC m = new MediaLibVLC(mLibVLC, "http://www.montemagno.com/sample.mp3");

                // Tell the media player to play the new Media.
                mMediaPlayer.Media = m;

                // Finally, play it!
                mMediaPlayer.Play();
            };
        }
    }
}


