using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {

        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.R, false)]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.NC_17, false)]
        [DataRow(MaturityRating.PG, true)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool isFriendly)
        {
            StreamingContent content = new StreamingContent("Genre", "Title", 4, StreamingQualityType.HD720, "description", "English", rating);

            bool actual = content.IsFamilyFriendly;
            bool expected = isFriendly;

            Assert.AreEqual(expected, actual);
        }
    }
}
