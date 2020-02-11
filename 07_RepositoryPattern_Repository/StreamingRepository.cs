using _07_RepositoryPattern_Repository.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepository : StreamingContentRepository
    {
        // Get All Shows - Method
        public List<Show> GetAllShows()
        {
            // Make a new list of Shows
            List<Show> shows = new List<Show>();
            // Look at all streaming content and check if it's a Show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show s) // Pattern Matching
                {
                    // Add each show to a list of Shows
                    //shows.Add((Show)content); // Casting
                    shows.Add(s);
                }
            }
            // Return our list of Shows
            return shows;
        }

        // Get All Movies - Method
        public List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie m) // Pattern Matching
                {
                    movies.Add(m);
                }
            }
            return movies;
        }

        // Get Show by Title - Method
        // Get Movie by Title - Method

        // Update Existing Show - Method
        // Update Existing Movie - Method

        // Delete Show By Title
        // Delete Movie By Title
    }
}
