using Lyrics.Objects;
using LyricsTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Artist TestArtist;
        [SetUp]
        public void Setup()
        {
            TestArtist = TestData.GetTestArtist();
        }

        [Test]
        public void GetAverageLyricsTest()
        {
            // Arrange data to be tested against
            var totalLyrics = 131.0 + 284.0 + 146.0 + 218.0;
            var numOfTracks = 4.0;
            var averageNumOfLyric = totalLyrics / numOfTracks;

            var testAverage = TestArtist.GetAverageLyrics();

            Assert.AreEqual(averageNumOfLyric, testAverage);
        }

        [Test]
        public void GetMostPopularLyric()
        {
            var predictedAnswer = "the";

            Assert.AreEqual(predictedAnswer, TestArtist.GetMostPopularLyric());

        }
    }
}