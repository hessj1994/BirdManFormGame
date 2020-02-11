using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum StreamingQualityType { SD240 =1, SD480, HD720, HD1080, UHD4K }
    public enum MaturityRating { G =1, PG, PG_13, R, NC_17 }

    public class StreamingContent
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public int StarRating { get; set; }
        public StreamingQualityType TypeOfStreamingQuality { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    default:
                        return false;
                }
            }
        }
        public MaturityRating MaturityRating { get; set; }

        public StreamingContent() { }
        public StreamingContent(string genre, string title, int starRating, StreamingQualityType typeOfQuality, string description, string language, MaturityRating maturityRating)
        {
            Genre = genre;
            Title = title;
            StarRating = starRating;
            TypeOfStreamingQuality = typeOfQuality;
            Description = description;
            Language = language;
            MaturityRating = maturityRating;
        }


        /*  Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 
        We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.

        filtering for family friendly -> content with inappropriate maturity ratings.
        replace the MaturityRating with a default set of options
        Based off of MRating
         IsFamilyFriendly to return the appropriate true or false.


        */
    }
}
