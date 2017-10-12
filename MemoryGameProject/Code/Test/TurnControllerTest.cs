using System.Windows.Forms;

namespace MemoryGameProject.Code.Test
{
    public class TurnControllerTest
    {
        private PlayerList playerList;
        private TurnController turnController;

        public TurnControllerTest(Timer turnTimer)
        {
            string[] playerNames = new string[4];
            playerNames[0] = "Alex";
            playerNames[1] = "Alexander";
            playerNames[2] = "Valeria";
            playerNames[3] = "Iemand";

            playerList = new PlayerList(playerNames);
            turnController = new TurnController(playerList, turnTimer);

            turnController.Begin();
        }

        public string Get()
        {
            string name = playerList.GetPlayerById(turnController.CurrentPlayerId).name;
            turnController.Next();

            return name;
        }
    }
}
