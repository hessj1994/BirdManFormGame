using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        public bool AddContentToDirectory(StreamingContent content)
        {
            int directoryLength= _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasAdded = directoryLength +1 == _contentDirectory.Count();
            return wasAdded;
        }

        public List<StreamingContent> GetAllContents()
        {
            return _contentDirectory;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;

        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.Genre = newContent.Genre;
                oldContent.Language = newContent.Language;
                oldContent.TypeOfStreamingQuality = newContent.TypeOfStreamingQuality;
                return true;
            }
                return false;
        }

        public bool DeleteExistingContent(string title)
        {
            StreamingContent foundContent = GetContentByTitle(title);
            bool deletedResult = _contentDirectory.Remove(foundContent);
            return deletedResult;
        }
    }
}
