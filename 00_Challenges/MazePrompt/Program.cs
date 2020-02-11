//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _00_Challenges.MazePrompt
//{
//    class Program
//    {//based on prompt, get new life at 10k points
//        //thread.Sleep(100) limits to 100ms between action
//        //consle.foregroundcolor --> changes cmd text
//        //cw before loop begins to have 'headers'
//        //chrome webpage *console* predict extension
//        // ProgramUI = new ProgramUI();
//        // ui.Fun();
//        static void Main(string[] args)
//        {
//            Game game = new Game();//make game class, run there
//            game.SetEvents

//            List<string> commands = new List<string>()
//        {
//            "Birb",
//            "Birb",
//            "OtherBirb";


//            string commandText = File.ReadAllText(path);
//            //List<string> commands = commandText.Split(',').ToList();
//            string[] commandArray = commandText.Split(',')
//            List<string> commands = commandArray.ToList();


//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Drofsnar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game game = new Game();
            Pacman game = new Pacman();
            //game.SetEvents(GetEventsFromFile("C:/Users/andre/source/repos/Drofsnar/Drofsnar/game-sequence.txt"));
            game.Run();
        }
        private static List<string> GetEventsFromFile(string path)
        {
            string text = File.ReadAllText("C:/Users/andre/source/repos/Drofsnar/Drofsnar/game-sequence.txt");
            return text.Split(',').ToList();
        }
    }
}
