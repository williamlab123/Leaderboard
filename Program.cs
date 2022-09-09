Console.WriteLine("Leaderboard v1.0");

Console.WriteLine("Login:");
string login = Console.ReadLine();


int rand = 0;
int Score = 0;

 int random()
 {
    Random rnd = new Random();
    int rando = rnd.Next(1000,9000);

    rand = rando;

    return rand;


 }


  int score()
  {
      Random rnd = new Random();
    int score = rnd.Next(1,101);

    Score = score;

    return Score;


  }
 
 loop:
  Console.WriteLine("Digite os nomes separando por um espaço entre eles");
   string nome1 =  Console.ReadLine();

 


 

   string[] nomes =  nome1.Split(' ');



    Random rnd = new Random();
    int addsco = rnd.Next(1, nomes.Length);







    if(addsco > nomes.Length)
    {
        addsco = rnd.Next(1, nomes.Length);
    }

    else if(nomes.Length == 1)
    {
      Console.WriteLine("adicione mais nomes");
      goto loop;
    }


  Console.Clear();
      for(int i = 0; i < nomes.Length; i++)
      {
         string addscore = nomes[i] +  "#score: " + score();
         Console.WriteLine(addscore);
      }



   random();



   Console.WriteLine("");
    Console.WriteLine("__________________");
    Console.ForegroundColor = ConsoleColor.Red;
     Console.WriteLine("login");
      string hash = rand.ToString();
      hash = login + '#' + hash;

      Console.WriteLine(hash);
  
  Console.ResetColor();