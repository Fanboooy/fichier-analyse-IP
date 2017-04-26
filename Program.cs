using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace adresseIP
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresseIP adresseIP = new AdresseIP();
            Console.WriteLine("entrez un nombre qui sera le premiere octet de votre adresse IP, ce nombre est compris entre 0 et 255");
            int nb1 = Convert.ToInt32(Console.ReadLine());
            while (nb1 < 0 || nb1 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le premiere octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                nb1 = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("entrez un nombre qui sera le deuxieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
            int nb2 = Convert.ToInt32(Console.ReadLine());
            while (nb2 < 0 || nb2 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le deuxieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                nb2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("entrez un nombre qui sera le troisième octet de votre adresse IP, ce nombre est compris entre 0 et 255");
            int nb3 = Convert.ToInt32(Console.ReadLine());
            while (nb3 < 0 || nb3 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le troisieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                nb3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("entrez un nombre qui sera le quatrième octet de votre adresse IP, ce nombre est compris entre 0 et 255");
            int nb4 = Convert.ToInt32(Console.ReadLine());
            while (nb4 < 0 || nb4 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le quatrieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                nb4 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("votre adressse IP est :" + nb1 + "." + nb2 + "." + nb3 + "." + nb4);
            if (nb1 <= 127)
            {
                Console.WriteLine("votre adresse est ce classe A");
            }
            else
            {
                if (nb1 >= 128 && nb1 <= 191)
                {
                    Console.WriteLine("Votre adrese est de classe B");
                }
                else
                {
                    if (nb1 >= 192 && nb1 <= 223)
                    {
                        Console.WriteLine("Votre adresse est de classe C");
                    }
                    else
                    {
                        Console.WriteLine("c'est bien une adresse IP mais de classe inconnu");
                    }
                }
            }
            Console.WriteLine("entrez le premiere octet de votre deuxieme adresse IP");
            int deuxNb1 = Convert.ToInt32(Console.ReadLine());
            while (deuxNb1 < 0 || deuxNb1 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le premiere octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                deuxNb1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("entrez le deuxieme octet de votre deuxieme adresse IP");
            int deuxNb2 = Convert.ToInt32(Console.ReadLine());
            while (deuxNb2 < 0 || deuxNb2 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le deuxieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                deuxNb2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("entrez le troisieme octet de votre deuxieme adresse IP");
            int deuxNb3 = Convert.ToInt32(Console.ReadLine());
            while (deuxNb3 < 0 || deuxNb3 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le troisieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                deuxNb3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("entrez le quatrieme octet de votre deuxieme adresse IP");
            int deuxNb4 = Convert.ToInt32(Console.ReadLine());
            while (deuxNb4 < 0 || deuxNb4 > 255)
            {
                Console.WriteLine("ce n'est pas un nombre attendu");
                Console.WriteLine("entrez un nombre qui sera le quatrieme octet de votre adresse IP, ce nombre est compris entre 0 et 255");
                deuxNb4 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("votre adressse IP est :" + deuxNb1 + "." + deuxNb2 + "." + deuxNb3 + "." + deuxNb4);
            if (deuxNb1 <= 127)
            {
                Console.WriteLine("votre adresse est ce classe A");
            }
            else
            {
                if (deuxNb1 >= 128 && nb1 <= 191)
                {
                    Console.WriteLine("Votre adrese est de classe B");
                }
                else
                {
                    if (deuxNb1 >= 192 && nb1 <= 223)
                    {
                        Console.WriteLine("Votre adresse est de classe C");
                    }
                    else
                    {
                        Console.WriteLine("c'est bien une adresse IP mais de classe inconnu");
                    }
                }
            }
            if (nb1 <= 127 && deuxNb1 <= 127 && nb1 == deuxNb1)
            {
                Console.WriteLine("vos deux adresse sont dans le meme reseau ");
            }
            else
            {
                if (nb1 <= 128 && nb1 >= 191 && deuxNb1 <= 128 && deuxNb1 >= 191 && nb1 == deuxNb1 && nb2 == deuxNb2)
                {
                    Console.WriteLine("vos deux adresse sont dans le meme reseau ");
                }
                else
                {
                    if (nb1 >= 192 && nb1 <= 223 && deuxNb1 >= 192 && deuxNb1 <= 223 & nb1 == deuxNb1 && nb2 == deuxNb2 && nb3 == deuxNb3)
                    {
                        Console.WriteLine("vos deux adresse sont dans le meme reseau ");
                    }
                    else
                    {
                        Console.WriteLine("vos deux adresse ne sont pas dans le meme reseau ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}



