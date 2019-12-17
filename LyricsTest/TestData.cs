using Lyrics.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LyricsTest
{
    // Static class to get pre-arranged test data
    public static class TestData
    {
        public static Artist GetTestArtist()
        {
            var artist = new Artist
            {
                Name = "Metallica",
                Albums = new List<Album>()
            };
            // 131 words
            var track1 = new Track
            {
                Name = "Hit The Lights",
                Lyrics = "No life till leather\nWe're gonna kick some ass tonight\nWe got the metal madness\nWhen our fans start screaming it's right\nWell alright\nWhen we start to rock,\nwe never\nWanna stop again\nHit the lights\nHit the lights\nHit the lights\nYou know our fans are insane\nWe are gonna blow this place away\nWith volume higher\nThan anything today,\nthe only way\nWhen we start to rock,\nwe never\nWanna stop again\nHit the lights\nHit the lights\nHit the lights\nWith all our screaming\nWe're gonna rip right through your brain\nWe got the lethal power\nIt is causing you sweet pain,\noh sweet pain\nWhen we start to rock,\nwe never\nWanna stop again\nHit the lights\nHit the lights\nHit the lights\nHit them lights."
            };
            // 284 words
            var track2 = new Track
            {
                Name = "The Four Horsemen",
                Lyrics = "By the last breath of the fourth winds blow\nBetter raise your ears\nThe sound of hooves knocks at your door\nLock up your wife and children now\nIt's time to wield the blade\nFor now you have got some company\nThe horsemen are drawing nearer\n the leather steeds they ride\nThey have come to take your life\nOn through the dead of night\nWith the four horsemen ride\nOr choose your fate and die\nOh yeah yeah\nYou have been dying since the day you were born\nYou know it has all been planned\nThe quartet of deliverance rides\nA sinner once a sinner twice\nNo need for confession now\n'Cause now you have got the fight of your life\nThe horsemen are drawing nearer\nOn the leather steeds they ride\nThey have come to take your life\nOn through the dead of night\nWith the four horsemen ride\nOr choose your fate and die\nOh yeah yeah\nTime has taken its toll on you\nThe lines that crack your face\nFamine, your body it has torn through\nWithered in every place\nPestilence, for what you have had to endure\nAnd what you have put others through\nDeath, deliverance for you for sure\nThere is nothing you can do\nSo gather round young warriors now\nAnd saddle up your steeds\nKilling scores with demon swords\nNow is the death of doers of wrong\nSwing the judgment hammer down\nSafely inside armor blood guts and sweat\nThe horsemen are drawing nearer\nOn the leather steeds they ride\nThey have come to take your life\nOn through the dead of night\nWith the four horsemen ride\nOr choose your fate and die\nOh yeah yeah"
            };
            // 146 words
            var track3 = new Track
            {
                Name = "Fight Fire With Fire",
                Lyrics = "Do unto others as they have done unto you\nBut what in the hell is this world coming to ?\nBlow the universe into nothingness\nNuclear warfare shall lay us to rest\nFight fire with fire\nEnding is near\nFight fire with fire\nBursting with fear\nWe shall die\nTime is like a fuse,\nshort and burning fast\nArmageddon is here,\nlike said in the past\nFight fire with fire\nEnding is near\nFight fire with fire\nBursting with fear\nSoon to fill our lungs the hot winds of death\nThe gods are laughing,\nso take your last breath\nFight fire with fire\nEnding is near\nFight fire with fire\nBursting with fear\nFight fire with fire\nFight fire with fire\nFight fire with fire\nFight fire with fire\nFight fire with fire\nFight fire with fire\nFight fire with fire\nFight fire with fire,\nfight"
            };
            // 218 words
            var track4 = new Track
            {
                Name = "Ride The Lightning",
                Lyrics = "Guilty as charged\nBut damn it,\nit ain't right\nThere is someone else controlling me\nDeath in the air\nStrapped in the electric chair\nThis can't be happening to me\nWho made you God to say\nI'll take your life from you\nFlash before my eyes\nNow it's time to die\nBurning in my brain\nI can feel the flames\nWait for the sign\nTo flick the switch of death\nIt's the beginning of the end\nSweat, chilling cold\nAs I watch death unfold\nConsciousness my only friend\nMy fingers grip with fear\nWhat I am doing here?\nFlash before my eyes\nNow it's time to die\nBurning in my brain\nI can feel the flames\nSomeone help me\nOh please God help me\nThey are trying to take it all away\nI don't want to die\nSomeone help me\nOh please God help me\nThey are trying to take it all away\nI don't want to die\nTime moving slowly\nThe minutes seem like hours\nThe final curtain call I see\nHow true is this ?\nJust get it over with\nIf this is true, just let it be\nWakened by the horrid Scream\nFreed from the frightening dream\nFlash before my eyes\nNow it's time to die\nBurning in my brain\nI can feel the flames"
            };
            var album1 = new Album
            {
                Name = "Kill em All",
                Tracks = new List<Track>()
            };
            var album2 = new Album
            {
                Name = "Ride The Lightning",
                Tracks = new List<Track>()
            };
            album1.Tracks.Add(track1);
            album1.Tracks.Add(track2);
            album2.Tracks.Add(track3);
            album2.Tracks.Add(track4);
            artist.Albums.Add(album1);
            artist.Albums.Add(album2);

            return artist;
        }
    }
}
