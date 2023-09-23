/*       
 *--------------------------------------------------------------------
 * 	   File name: Program.cs
 * 	Project name: Query Builder
 *--------------------------------------------------------------------
 * Author’s name and email:	 Kyah Hanson - hansonkm@etsu.edu				
 *          Course-Section:  CSCI-2910-800
 *           Creation Date:	 9/18/2023		
 * -------------------------------------------------------------------
 */
using QueryBuilder;
using QueryBuilder.Models;

using System.ComponentModel.DataAnnotations;
var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
var dbPath = root + "\\data\\data.db";
QueryBuilder.QueryBuilder query = new QueryBuilder.QueryBuilder(dbPath);


string pokemonFile = root + "\\data\\AllPokemon.csv";
List<Pokemon> pokemonList = new List<Pokemon>();
int pokemonID = 0;

string gameFile = root + "\\data\\BannedGames.csv";
List<BannedGame> gameList = new List<BannedGame>();
int gameID = 0;

using (query)
{
    query.DeleteAll<Pokemon>();
    Console.WriteLine("All Pokemon have been deleted");
    query.DeleteAll<BannedGame>();
    Console.WriteLine("All banned games have been deleted");

    
    // Adding all pokemon to the data base
    using (StreamReader pokemonReader = new StreamReader(pokemonFile))
    {
        while (!pokemonReader.EndOfStream)
        {
            string newPokemon = pokemonReader.ReadLine();
            string[] pokemonData = newPokemon.Split(',');
            pokemonID++;
            Pokemon newP = new Pokemon(pokemonID, Convert.ToInt32(pokemonData[0]), pokemonData[1], pokemonData[2], pokemonData[3], pokemonData[4], Convert.ToInt32(pokemonData[5]), Convert.ToInt32(pokemonData[6]), Convert.ToInt32(pokemonData[7]), Convert.ToInt32(pokemonData[8]), Convert.ToInt32(pokemonData[9]), Convert.ToInt32(pokemonData[10]), Convert.ToInt32(pokemonData[11]), Convert.ToInt32(pokemonData[12]));
            pokemonList.Add(newP);
            
        }
        pokemonReader.Close();
    }
    
    foreach(var pokemon in pokemonList)
    {
        query.Create(pokemon);
    }
    Console.WriteLine("All 1045 pokemon have been added to the data base.");


    // Adding all banned books to the data base
    using (StreamReader gameReader = new StreamReader(gameFile))
    {
        while (!gameReader.EndOfStream)
        {
            string newGame = gameReader.ReadLine();
            string[] gameData = newGame.Split(',');
            gameID++;
            BannedGame newG = new BannedGame(gameID, gameData[0], gameData[1], gameData[2], gameData[3]);
            gameList.Add(newG);
        }
        gameReader.Close();
    }

    foreach (var game in gameList)
    {
        query.Create(game);
    }
    Console.WriteLine("All 136 banned games have been added to the data base.");


    // Add single Pokemon
    Pokemon singlePokemon = new Pokemon(pokemonID + 1, 937, "Ceruledge", "Female", "Fire", "Ghost", 525, 75, 125, 80, 60, 100, 85, 9);
    query.Create(singlePokemon);
    Console.WriteLine("The Pokemon 'Ceruledge' was added to the data base.");

    // Add single bannded game
    BannedGame singleGame = new BannedGame(gameID + 1, "Mortal Kombat II", "Mortal Kombat", "Indonesia", "Banned because of excessive violence and gore.");
    query.Create(singleGame);
    Console.WriteLine("The banned game 'Mortal Kombat II' was added to the data base.");
}


