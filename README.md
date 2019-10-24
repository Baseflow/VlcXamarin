# VlcXamarin

Xamarin bindings library for VLC player library for Android

For more information on VLC see the [Developer documentation](https://github.com/mrmaffen/vlc-android-sdk)

Find latest [Java lib](https://bintray.com/steiner/maven/libvlc-android/)

Plugin is available on [Nuget](https://www.nuget.org/packages/Xam.Plugins.Android.VlcXamarin/)

# Support

* Feel free to open an issue. Make sure to use one of the templates!
* Commercial support is available. Integration with your app or services, samples, feature request, etc. Email: [hello@baseflow.com](mailto:hello@baseflow.com)
* Powered by: [baseflow.com](https://baseflow.com)

Documentation
=============

    LibVLCLibVLC mLibVLC = null;
    MediaPlayer mMediaPlayer = null;
    
    if(mLibVLC == null)
    {
        //Initialize VLC libs
        mLibVLC = new LibVLCLibVLC(this);
        mMediaPlayer = new MediaPlayer(mLibVLC);
    }
    //Create new media object
    var m = new MediaLibVLC(mLibVLC, Android.Net.Uri.Parse("http://www.montemagno.com/sample.mp3"));

    // Tell the media player to play the new Media.
    mMediaPlayer.Media = m;

    // Finally, play it!
    mMediaPlayer.Play();

See the VlcXamarin.Sample sample app for more details.

Acknowledgements
=======

* [thefex](https://github.com/thefex) for helping with several issue's

License
=======

- **VlcXamarin** plugin is licensed under MIT
