// Console.WriteLine(" Quel age avez vous? : ");
//         int age_user;
//         age_user = Convert.ToInt32 (Console.ReadLine());

//         if (age_user < 1){

//             Console.WriteLine("le programme plante");

//         }

//          if (age_user < 18)
//         {
//             Console.WriteLine("Vous etes mineur. ");

//         }

//         if (age_user > 18 )
//         {
//             Console.WriteLine("Vous etes majeur. ");

//                 if  (age_user >=25 && age_user <30 )
//                 {
//                     Console.WriteLine("tu commences ton chemin d’adulte. ");
//                 }

//                 else if(age_user >=30 && age_user<70)
//                 {

//                     Console.WriteLine("Vous etes adulte. ");
//                 }
//                 else if (age_user >=70){

//                     Console.WriteLine("vous êtes en béton armé !");
//                 }

//         }


Console.WriteLine("Vous pouvez rentrer vos pas:");



string[] moves = new string[32];
int i = 0; //declaration du compteur
string move = ""; //declaration variable tester dans le while

while (i < 32 && move != "done"/*|| Si l'utilisateur rentre "done"*/)
{
    Console.WriteLine("Pas numero " + i + " :");
    // Utilisateur met un truc
    move = Console.ReadLine();
    if (move != "done")
    {
        moves[i] = move;
    }
    i++;

}

Console.WriteLine("Veuillez entrer le nombre d'itérations de la chorégraphie");
int nbIteration = Convert.ToInt32(Console.ReadLine());


for (int compteur = 0; compteur < nbIteration;)
{

    Console.WriteLine($"Iteration numero {compteur}");

    for (int compteurPas = 0; compteurPas < 32; compteurPas++)
    {

        Console.Write(" - "+moves[compteurPas]);

    }
    Console.WriteLine("");
    compteur++;
}

