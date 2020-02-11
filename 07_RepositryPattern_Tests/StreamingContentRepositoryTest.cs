using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            bool addResult = repository.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_SHouldReturnCorrectCollection()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(content);

            List<StreamingContent> contents = repo.GetAllContents();

            bool directoryHasContent = contents.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Drama","Rubber",1,StreamingQualityType.UHD4K, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.","French",MaturityRating.R);
            _repo.AddContentToDirectory(_content);

        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            Assert.AreEqual(_content, searchResult);
        }
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Drama", "Rubber", 100, StreamingQualityType.SD240, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", "French", MaturityRating.R);
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            Assert.IsTrue(updateResult);

        }
        [TestMethod]
        public void MyTestMethod()
        {
            bool removeResult = _repo.DeleteExistingContent("Rubber");
            Assert.IsTrue(removeResult);
        }
    }
}
