using _07_RepositoryPattern_Repository;
using _07_RepositoryPattern_Repository.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();
        //14. method to take in console instance, of any IConsole
        //new instance, give value -> construct class, need constructer
        //17. dont need to make public, any type of console
        private IConsole _console;//18. going to set value in constructor for field
        public ProgramUI(IConsole console)//15. ctor tab tab, trying to pass in iconsole
        {//16. need to put console somewhere accessible in the whole class, then pass it around to all methods that can use it, put outside all methods = field, underscore camelcase
            _console = console;//19. everywhere have console.???  need to replace with _field
        }
        //20. ctrl f, replace Console with_console, match case and whole word

        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear(); //20. replaced with interface instance
                //32.   This is value that will be shown in OutPut
                _console.WriteLine("Select an option number:\n" +
                    "1. Display all streaming content\n" +
                    "2. Display all Shows\n" +
                    "3. Display all Movies\n" +
                    "4. Add streaming content\n" +
                    "5. Update existing content\n" +
                    "6. Remove streaming content\n" +
                    "7. Exit");

                string userInput = _console.ReadLine();
                userInput = userInput.Replace(" ", "");
                userInput = userInput.Trim();

                switch (userInput)
                {
                    case "1":
                        //-- Show All Content
                        ShowAllContent();
                        break;
                    case "2":
                        //-- Display All Shows
                        ShowAllShows();
                        break;
                    case "3":
                        //-- Display All Movies
                        break;
                    case "4":
                        //-- Add New Content
                        AddNewStreamingContent();
                        break;
                    case "5":
                        //-- Update Content
                        UpdateContent();
                        break;
                    case "6":
                        //-- Delete Content
                        break;
                    case "7":
                        //-- Exit
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        //Access to streaming repo/the add method 
        //Prompt the user 
        //Take in content 
        //Actually add the content through our add method 
        private void AddNewStreamingContent()
        {
            StreamingContent content = new StreamingContent();
            _console.WriteLine("Hello there, please enter a title");
            content.Title = _console.ReadLine();

            _console.WriteLine("Now, add a description");
            content.Description = _console.ReadLine();

            _console.WriteLine("What is the genre");
            content.Genre = _console.ReadLine();

            _console.WriteLine("What is the star rating?");
            content.StarRating = Convert.ToInt32(_console.ReadLine());
            //content.StarRating = int.Parse(_console.ReadLine());

            _console.WriteLine("Select a Maturity rating (enter a value between 1 and 5)\n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG 13 \n" +
                "4) R \n" +
                "5) NC 17");

            string maturityString = _console.ReadLine();
            int ratingID = int.Parse(maturityString);
            content.MaturityRating = (MaturityRating)ratingID;

            _console.WriteLine("Select a streaming Quality from below (choose a value between 1 and 5 \n" +
                "1) SD240 \n" +
                "2) SD480 \n" +
                "3) HD720 \n" +
                "4) HD1080 \n" +
                "5) UHD4k");
            string userInput = _console.ReadLine();
            switch (userInput)
            {
                case "1":
                    content.TypeOfStreamingQuality = StreamingQualityType.SD240;
                    break;
                case "2":
                    content.TypeOfStreamingQuality = StreamingQualityType.SD480;
                    break;
                case "3":
                    content.TypeOfStreamingQuality = StreamingQualityType.HD720;
                    break;
                case "4":
                    content.TypeOfStreamingQuality = StreamingQualityType.HD1080;
                    break;
                case "5":
                    content.TypeOfStreamingQuality = StreamingQualityType.UHD4K;
                    break;
            }
            _console.WriteLine("Last step! What language is this content");
            content.Language = _console.ReadLine();

            _streamingRepo.AddContentToDirectory(content);
            _console.WriteLine("Your content has been added! Press any key to return to the main menu");
            _console.ReadKey();

        }

        //Display all shows
        //make a list -> 
        //add to the list (shows)
        //Display the shows 
        private void ShowAllShows()
        {
            List<Show> shows = new List<Show>();
            shows = _streamingRepo.GetAllShows();
            foreach (Show content in shows)
            {
                _console.WriteLine($"Title: {content.Title} \n" +
                    $"Genre: {content.Genre} \n" +
                    $"Star Rating: {content.StarRating} \n" +
                    $"What is it about?{content.Description} \n" +
                    $"Words: {content.Language} \n" +
                    $"Streaming Quality: {content.TypeOfStreamingQuality} \n" +
                    $"Maturity Rating {content.MaturityRating} \n" +
                    $"Is family friendly: {content.IsFamilyFriendly} \n" +
                    $"Runtime: {content.AverageRunTime} \n" +
                    $"Episode count: {content.EpisodeCount} \n" +
                    $"Season Count: {content.SeasonCount} \n" +
                    $"Episode List: ");
                foreach (Episode episode in content.Episodes)
                {
                    _console.WriteLine(episode.Title);
                }

            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
        private void ShowAllContent()
        {
            _console.Clear();

            // Get all of our content
            List<StreamingContent> directory = _streamingRepo.GetAllContents();

            // Go through each item and display its properties
            foreach (StreamingContent content in directory)
            {
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Rating: {content.MaturityRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Streaming Quality: {content.TypeOfStreamingQuality}\n" +
                    $"Language: {content.Language}");
            }

            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        // Update Existing Content
        // Find existing content
        // Create an updated version
        // Pass the updated content to the repository Update method
        private void UpdateContent()
        {
            _console.WriteLine("Enter title of content you would like to update:");
            string titleInput = _console.ReadLine();
            StreamingContent existingContent = _streamingRepo.GetContentByTitle(titleInput);

            if (existingContent == null)
            {
                _console.WriteLine("There is no content with that Title.\n" +
                    "Press any key to continue...");
                _console.ReadKey();
            }
            else
            {
                StreamingContent content = new StreamingContent();
                _console.WriteLine($"Current title is {existingContent.Title}, please enter a new title");
                content.Title = _console.ReadLine();

                _console.WriteLine($"Current description is {existingContent.Description}." +
                    $"\nPlease enter new description:");
                content.Description = _console.ReadLine();

                _console.WriteLine($"Current genre is {existingContent.Genre}. Enter the new genre:");
                content.Genre = _console.ReadLine();

                _console.WriteLine($"Current Star Rating: {existingContent.StarRating}. Enter new star rating:");
                content.StarRating = Convert.ToInt32(_console.ReadLine());
                //content.StarRating = int.Parse(_console.ReadLine());

                _console.WriteLine($"Current Maturity Rating: {existingContent.MaturityRating}\n" +
                    $"Enter new Maturity Rating: (enter a value between 1 and 5)\n" +
                    "1) G \n" +
                    "2) PG \n" +
                    "3) PG 13 \n" +
                    "4) R \n" +
                    "5) NC 17");

                string maturityString = _console.ReadLine();
                int ratingID = int.Parse(maturityString);
                content.MaturityRating = (MaturityRating)ratingID;

                _console.WriteLine($"Current Quality: {existingContent.TypeOfStreamingQuality}.\n" +
                    $"Enter new Quality type: (Choose a value between 1 and 5) \n" +
                    "1) SD240 \n" +
                    "2) SD480 \n" +
                    "3) HD720 \n" +
                    "4) HD1080 \n" +
                    "5) UHD4k");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        content.TypeOfStreamingQuality = StreamingQualityType.SD240;
                        break;
                    case "2":
                        content.TypeOfStreamingQuality = StreamingQualityType.SD480;
                        break;
                    case "3":
                        content.TypeOfStreamingQuality = StreamingQualityType.HD720;
                        break;
                    case "4":
                        content.TypeOfStreamingQuality = StreamingQualityType.HD1080;
                        break;
                    case "5":
                        content.TypeOfStreamingQuality = StreamingQualityType.UHD4K;
                        break;
                }
                _console.WriteLine($"Current Language: {existingContent.Language}. Enter new Language:");
                content.Language = _console.ReadLine();

                _streamingRepo.UpdateExistingContent(existingContent.Title, content);
                _console.WriteLine("Your content has been updated. Press any key to continue...");
                _console.ReadKey();
            }
        }

        private void SeedContent()
        {
            StreamingContent toyStory = new StreamingContent("Bromance", "Toy Story", 10, StreamingQualityType.HD720, "A good childhood movie.", "English", MaturityRating.G);
            _streamingRepo.AddContentToDirectory(toyStory);

            Movie rubber = new Movie("Drama", "Rubber", 6, StreamingQualityType.HD1080, "Tyre comes to life and kills people with its mind powers.", "English/French", MaturityRating.R, 85);
            _streamingRepo.AddContentToDirectory(rubber);

            Show avatar = new Show("Adventure", "Avatar", 9, StreamingQualityType.HD1080, "The last airbender", "English", MaturityRating.G, new List<Episode>());
            _streamingRepo.AddContentToDirectory(avatar);
        }
    }
}
