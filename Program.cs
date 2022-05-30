using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Login_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string username = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (File.Exists("login.txt"))
            {
                if (File.ReadAllText("login.txt").Contains(username + ":" + senha))
                {
                    Console.WriteLine("Sucesso ao logar");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Falha ao logar");
                    Console.ReadLine();
                }
            }
            else
            {
                File.WriteAllText("login.txt", username + ":" + senha);
                Console.WriteLine("Login criado com sucesso");
                Console.ReadLine();
            }
        }
    }
}
