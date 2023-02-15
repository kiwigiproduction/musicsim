using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SongManager;

public class SongManager    :   MonoBehaviour //some class
{
    Person person = new Person();

    public List<Songs> songs = new List<Songs>();



    public void SongItem(List<Songs> songs)
    {
        var SongList = songs;

    }

    public void CreateSongSingle(Person person, List<Songs> songs)
    {
        var songName = "";
        var songTitle = "";
        var SongRate = "";

        var SongsList = songs;




    }
    public class Person
    {
    }


    public class Songs
    {
    }

}


