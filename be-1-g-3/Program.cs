using System.Xml.Linq;

namespace be_1_g_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("BENVENUTO DA STROZZINI.MAFIA SPA");
            Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Versa l'importo iniziale");
            int primoVersamento = int.Parse(Console.ReadLine());
            bool end = false;
            if (primoVersamento < 1000)
            {   
                Console.WriteLine("Devi versare almeno 1000 euro per poter iniziare");
                end = true;
            }
            ContoCorrente user = new ContoCorrente(nome, cognome, primoVersamento);
            
            while (!end) 
            {   
                Console.WriteLine($"Benvenuto {nome} {cognome} che operazioni vuoi fare oggi?");
                Console.WriteLine("Per prelevare digita 1");
                Console.WriteLine("Per versare digita 2");
                Console.WriteLine("Per chiudere il terminale digita 3");
                Console.Write("Scegli l'opzione: ");
                string option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":
                        user.Withdraw();
                        break;

                    case "2":
                        user.Deposit();
                        break;

                    case "3":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Segui le istruzioni per eseguire le operazioni");
                        break;
                }
            }
        }
    }
    public class ContoCorrente
    {
        string _name;
        string _surname;
        int _saldo;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }

        }
        public ContoCorrente(string name, string surname, int saldo)
        {
            Name = name;
            Surname = surname;
            Saldo = saldo;
        }
        public void Withdraw()
        {
            Console.WriteLine("Quanto vuoi prelevare?");
            int tot = int.Parse(Console.ReadLine());
            if (tot > Saldo)
            {
                Console.WriteLine("Vai a lavorare poraccio");
            }
            else if (tot == 0)
            {
                Console.WriteLine("Non puoi ritirare 0 euro");
            }
            
            else
            {
                Saldo = Saldo - tot;
                Console.WriteLine($"Hai ritirato {tot}. Il tuo nuovo saldo è {Saldo}");
            }
        }
        public void Deposit()
        {
            Console.WriteLine("Quanto vuoi versare?");
            int tot = int.Parse(Console.ReadLine());
            if (tot == 0)
            { 
                Console.WriteLine("Non puoi versare 0 euro");
            } else 
            { 
                Saldo = Saldo + tot;
                Console.WriteLine($"Hai versato {tot}.Il tuo nuovo saldo è {Saldo}");
            }
        }
    }   
}
