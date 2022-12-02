public class Program {
    
    public static void Main(){

        // Loop through the game - keep track of winning and losing
        int timesToPlay = 1000000;
        int winCount = 0;
        int loseCount = 0;
        bool willSwap = true;

        for (int i = 1; i <= timesToPlay; i++) { 
            if (playGame(willSwap) == false) {
                winCount++;
            }
            else {
                loseCount++;
            } 
        }

        decimal winPercent = (Convert.ToDecimal(winCount)/Convert.ToDecimal(timesToPlay))*100;
        Console.WriteLine(String.Format("Total Games Played: {0}", timesToPlay));
        Console.WriteLine(String.Format("Total Wins: {0}", winCount));
        Console.WriteLine(String.Format("Total Losses: {0}", loseCount));
        Console.WriteLine(String.Format("Win Percent: {0}", winPercent));

    }

    static Boolean playGame(bool gamerswitch) {
        
        // Get the positions 
        Random rand = new Random();
        int gamerPosition = rand.Next(1,4);
        int winPosition = rand.Next(1,4);


        int montyPosition=0;

        // Monty opens a non winning door that isnt the gamers position
        for (int i = 1; i <= 3; i++) {
            if (i!=winPosition) {
                montyPosition = i;
            }
        }


        // Does the gamer switch;
        if (gamerswitch) {
            // pick the position that isnt the gamer or monty position
            for (int i = 1; i <= 3; i++) { 
                if (i!=gamerPosition && i!=montyPosition) {
                    gamerPosition=i;
                }
            }
        }

        // Return result
        return (gamerPosition==winPosition) ? true : false;

    }

}
