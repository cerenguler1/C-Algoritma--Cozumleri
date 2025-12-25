using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Bir cümle giriniz: ");
                string cümle = Convert.ToString(Console.ReadLine());

                //anahtar kelimelerimizi tanımlıyoruz
                string[] keywords = { "sand", "water", "fish", "sun" };

                //büyük/küçük harf sorunu için girilen cümleyiküçük harfe çeviriyoruz
                string küçükharf = cümle.ToLower();

                //anahtar kelimelerin toplam sayısını tutmak için;
                int toplam = 0;


                for (int i = 0; i < keywords.Length; i++)
                {
                    string keyword = keywords[i];
                    int count = 0;


                    for (int a = 0; a <= küçükharf.Length - keyword.Length; a++)
                    {

                        if (küçükharf.Substring(a, keyword.Length) == keyword)
                        {
                            count++;
                        }
                    }
                    toplam += count;
                }
                Console.WriteLine(toplam);
                Console.ReadKey();
            }
        }
    }


