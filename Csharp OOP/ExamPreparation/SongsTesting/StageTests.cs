// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    //using FestivalManager.Entities;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
	public class StageTests
    {
		[Test]
	    public void CheckIfTheConstructor()
	    {
			//Assert.DoesNotThrow(() =>
			//{
			//	Stage stage = new Stage();
			//});

			Stage stage = new Stage();
			List<Performer> expectedPerformers = new List<Performer>();

			var actualPerformers = stage.Performers;

			CollectionAssert.AreEqual(expectedPerformers, actualPerformers);
		}

		[Test]
		public void CheckIfIReadOnlyCollectionWorks()
		{
			Stage stage = new Stage();
			List<Performer> expectedPerformers = new List<Performer>();

			var actualPerformers = stage.Performers;

			CollectionAssert.AreEqual(expectedPerformers, actualPerformers);
		}

		[Test]
		public void CheckIfAddPerformerMethodWorksWithCorrectData()
        {
			Performer performer = new Performer("Name", "LastName", 19);
			Stage stage = new Stage();
			stage.AddPerformer(performer);
			//List<Performer> performersList = new List<Performer> { performer };

			Assert.AreEqual(1, stage.Performers.Count);
        }

		[Test]
		public void CheckIfAddPerformerMethodWorksWithNull()
		{
			Assert.Throws<ArgumentNullException>(() =>
			{
				Performer performer = null;
				Stage stage = new Stage();
				stage.AddPerformer(performer);
			});
		}

		[Test]
		public void CheckIfAddPerformerMethodWorksWith17OrLessYearsOld()
		{
			Assert.Throws<ArgumentException>(() =>
			{
				Performer performer = new Performer("Name", "LastName", 17);
				Stage stage = new Stage();
				stage.AddPerformer(performer);
			}, "You can only add performers that are at least 18.");
		}

		[Test]
		public void CheckIfAddSongMethodWorksWithCorrectData()
		{
			Assert.DoesNotThrow(() =>
			{ 
			TimeSpan ts = new TimeSpan(0, 2, 8);
			Song song = new Song("Song", ts);
			Stage stage = new Stage();
			stage.AddSong(song); 
			});
		}

		[Test]
		public void CheckIfAddSongMethodWorksWithNull()
		{
			Assert.Throws<ArgumentNullException>(() =>
			{
				Song song = null;
				Stage stage = new Stage();
				stage.AddSong(song);
			});
		}

		[Test]
		public void CheckIfAddSongMethodWorksWithDurationLessThanAMinute()
		{
			Assert.Throws<ArgumentException>(() =>
			{
				TimeSpan ts = new TimeSpan(0, 0, 8);
				Song song = new Song("Song", ts);
				Stage stage = new Stage();
				stage.AddSong(song);
			},"You can only add songs that are longer than 1 minute.");
		}

		[TestCase("Song", "a", "b")]
		public void CheckIfAddSongToPerformerWorksWithCorrectData(string songName, string performerFirstName, 
			string performerLastName)
        {
				Stage stage = new Stage();
				Performer performer = new Performer(performerFirstName, performerLastName, 32);
				TimeSpan ts = new TimeSpan(0, 2, 8);
				Song song = new Song(songName, ts);
				stage.AddSong(song);
				stage.AddPerformer(performer);
				string actualOutput = stage.AddSongToPerformer("Song", "a b");
			string expectedOutput = $"{songName} will be performed by {performer.FullName}";
		}

		[TestCase(null, "a", "b")]
		public void CheckIfAddSongToPerformerWorksWithNullSong(string songName, string performerFirstName,
			string performerLastName)
		{
			Assert.Throws<ArgumentNullException>(() =>
			{
				Stage stage = new Stage();
				Performer performer = new Performer(performerFirstName, performerLastName, 32);
				TimeSpan ts = new TimeSpan(0, 2, 8);
				Song song = new Song(songName, ts);
				stage.AddSong(song);
				stage.AddPerformer(performer);
				stage.AddSongToPerformer(songName, performerFirstName+" "+performerLastName);
			});
		}

		[Test]
		public void CheckIfAddSongToPerformerWorksWithNullPerformer()
		{
			Assert.Throws<ArgumentNullException>(() =>
			{
				Stage stage = new Stage();
				string performerName = null;
				stage.AddSongToPerformer("Song", performerName);
			});
		}

		[TestCase("Song1", "a", "b")]
		[TestCase("Song", "a", "c")]
		public void CheckIfAddSongToPerformerWorksWithMissingSongOrPerformer(string songName, string performerFirstName,
			string performerLastName)
		{
			Assert.Throws<ArgumentException>(() =>
			{
				Stage stage = new Stage();
				Performer performer = new Performer(performerFirstName, performerLastName, 32);
				TimeSpan ts = new TimeSpan(0, 2, 8);
				Song song = new Song(songName, ts);
				stage.AddSong(song);
				stage.AddPerformer(performer);
				stage.AddSongToPerformer("Song", "a b");
			});
		}

		[Test]
		public void CheckIfPlayMethodWorks()
        {
			Stage stage = new Stage();
			Performer performer1 = new Performer("a", "b", 32);
			Performer performer2 = new Performer("c", "k", 32);
			Performer performer3 = new Performer("h", "p", 32);
			TimeSpan ts1 = new TimeSpan(0, 2, 8);
			TimeSpan ts2 = new TimeSpan(0, 4, 8);
			TimeSpan ts3 = new TimeSpan(0, 7, 8);
			Song song1 = new Song("l", ts1);
			Song song2 = new Song("w", ts2);
			Song song3 = new Song("x", ts3);
			stage.AddSong(song1);
			stage.AddSong(song2);
			stage.AddSong(song3);
			stage.AddPerformer(performer1);
			stage.AddPerformer(performer2);
			stage.AddPerformer(performer3);
			stage.AddSongToPerformer("l", "a b");
			stage.AddSongToPerformer("w", "c k");
			stage.AddSongToPerformer("x", "h p");
			var expectedPlayReview = "3 performers played 3 songs";
			var actualPlayReview = stage.Play();

			Assert.AreEqual(expectedPlayReview, actualPlayReview);
		}

		[Test]
		public void CheckIfPlayMethodWorksWith0Songs()
		{
			Stage stage = new Stage();
			Performer performer1 = new Performer("a", "b", 32);
			Performer performer2 = new Performer("c", "k", 32);
			Performer performer3 = new Performer("h", "p", 32);
			TimeSpan ts1 = new TimeSpan(0, 2, 8);
			TimeSpan ts2 = new TimeSpan(0, 4, 8);
			TimeSpan ts3 = new TimeSpan(0, 7, 8);
			Song song1 = new Song("l", ts1);
			Song song2 = new Song("w", ts2);
			Song song3 = new Song("x", ts3);
			stage.AddSong(song1);
			stage.AddSong(song2);
			stage.AddSong(song3);
			stage.AddPerformer(performer1);
			stage.AddPerformer(performer2);
			stage.AddPerformer(performer3);
			var expectedPlayReview = "3 performers played 0 songs";
			var actualPlayReview = stage.Play();

			Assert.AreEqual(expectedPlayReview, actualPlayReview);
		}
	}
}