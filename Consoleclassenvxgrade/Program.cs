namespace Consoleclassenvxgrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nbqueteshero;
            int niveau;
            char guerrier = 'G';
            char mage = 'M';
            char rogue = 'R';
            string grade;
            Console.WriteLine("Choisissez votre niveau");
            niveau = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choisissez votre classe (G pour Guerrier, M pour Mage, R pour Rogue)");
            char classe = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Combien de quêtes avez-vous accomplies ?");
            Nbqueteshero = Convert.ToInt32(Console.ReadLine());

            if (niveau < 10)
            {
                grade = "Novice";
            }
            else if (niveau >= 10 && niveau < 20)
            {
                grade = "Adepte";
            }
            else if (niveau >= 20 && niveau < 30)
            {
                grade = "Apprenti Assermenté";
            }
            else if (niveau >= 20 && niveau < 30)
            {
                grade = "Vétéran";
            }
            else if (niveau >= 30 && Nbqueteshero >= 20)
            {
                grade = "Maitre de Guilde";
            }
            else
            {
                grade = "statut indeterminé / hors-la-loi";
            }

            Console.WriteLine($"vous etes de niveau {niveau} et votre grade est {grade}");
        }
    }
}
