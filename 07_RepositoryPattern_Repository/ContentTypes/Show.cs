using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.ContentTypes
{
    public class Show : StreamingContent
    {
        public Show() { }
        public Show(string genre, string title, int starRating, StreamingQualityType typeOfQuality, string description, string language, MaturityRating maturityRating, List<Episode> episodes)
             : base(genre, title, starRating, typeOfQuality, description, language, maturityRating)
        {
            Episodes = episodes;
        }

        public List<Episode> Episodes { get; set; } = new List<Episode>();

        // Look into Hashsets
        // Check each episode and add its season number to a collection
        // Look for all unique season numbers (Count from Hashset)
        public int SeasonCount
        {
            get
            {
                HashSet<int> seasonNumbers = new HashSet<int>();
                foreach(Episode episode in Episodes)
                {
                    seasonNumbers.Add(episode.SeasonNumber);
                }
                return seasonNumbers.Count;
            }
        }

        // Return the Count from our Episodes property
        public int EpisodeCount
        {
            //get => Episodes.Count; //-- Expression Body
            get
            {
                return Episodes.Count; //-- Block Body
            }
        }
        public double AverageRunTime
        {
            get
            {
                // declare a total runtime starting at 0
                double totalRunTime = 0;
                // add each episode's runtime to my total
                foreach (Episode individualEpisode in Episodes)
                {
                    totalRunTime = totalRunTime + individualEpisode.RunTime;
                }
                // divide our total runtime by our total episode count
                double averageRunTime = totalRunTime / EpisodeCount;
                // return the calculated average
                return averageRunTime;
            }
        }
    }

    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
    }
}
