# Tournament-Manager
That is a app for creating and handle a tournament and all the sports game from it. Sets up a schedule for teams to play each other in a single-elimination style matchups.

Use cases:
  - Office game
  - 3v3 basketball leagues
  - Football leagues
  - Esports leagues
  - And many more...

The C# "technology" used to develop app includes:
  - Multi-form WinForms application
  - In-depth Class Library
  - Microsoft SQL Server Database
  - Text File Storage
  - Dapper
  - Linq
  - Interfaces - to change between SQL DB and Text File Storage
  - Emailing from C# - Using Papercut SMTP
  - Custom Events

# How it works
1. Traks games played and their outcome (who won).
2. Multiple competitors play in the tournament.
3. Creates a tournament plan (who plays in what order).
4. Schedules games.
5. A single loss eliminates a player.
6. The last player standing is the winner.

Mapping the Data:

Team:
  - Team Members (List<Person>)
  - Team Name (string)
  
Person:
  - First Name (string)
  - Last Name (string)
  - Email Adress (string)
  - Cellphone Number (string)
  
Tournament:
  - Tournament Name (string)
  - EntryFee (decimal)
  - Entered Teams (List<Team>)
  - Prizes (List<Prize>)
  - Rounds(List<List<Matchups>>)
  
Prize:
  - Place Number (int)
  - Place Name (string)
  - Prize Amount (decimal)
  - Prize Percentage (double)
  
Matchup:
  - Entries (List<MatchupEntry>)
  - Winner (Team)
  - Matchup Round (int)

MatchupEntry:
  - Team Competing (Team)
  - Score (double)
  - Parent Matchup (Matchup)

App screens:

![image](https://user-images.githubusercontent.com/52401139/134587280-95948370-c82b-42e2-9ccf-7571582a12ed.png)
![image](https://user-images.githubusercontent.com/52401139/134587290-74877e86-e752-45f8-915a-c8ba82ee0ca4.png)
![image](https://user-images.githubusercontent.com/52401139/134587306-cc9e3842-61c9-4b00-b699-bb4d50f9cb2b.png)
![image](https://user-images.githubusercontent.com/52401139/134587315-6fecabfd-9d0a-47c6-8a01-cac1842783cc.png)
![image](https://user-images.githubusercontent.com/52401139/134587327-5bc44af8-c504-4810-b745-d7633205ce7b.png)
