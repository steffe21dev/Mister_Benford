using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Figgle;

namespace Mister_Benford
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine(FiggleFonts.Graceful.Render("Benfords Lag"));

            //Felhantering
            try
            {
                //Knappa in urlen
                string url = "https://www.nomoda.net/";
                double[] tal;

                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(url);

                var htmlbody = doc.DocumentNode.SelectSingleNode("//body");
                string body = htmlbody.InnerText;


                tal = Kalkylera_FörstaSiffror(body);


                Console.WriteLine(string.Format(" Antalet ettor: {0} \n Antalet tvåor: {1} \n Antalet treor: {2} \n Antalet fyror: {3} \n Antalet femmor: {4} \n Antalet sexor: {5} \n Antalet sjuor: {6} \n Antalet åttor: {7} \n Antalet nior: {8} \n", tal[1], tal[2], tal[3], tal[4], tal[5], tal[6], tal[7], tal[8], tal[9]));
                Console.WriteLine(string.Format(" Antalet ettor: {0} \n Antalet tvåor: {1} \n Antalet treor: {2} \n Antalet fyror: {3} \n Antalet femmor: {4} \n Antalet sexor: {5} \n Antalet sjuor: {6} \n Antalet åttor: {7} \n Antalet nior: {8} \n",
                    (double)((tal[1] / tal[0]) * 100), ((tal[2] / tal[0]) * 100), ((tal[3] / tal[0]) * 100), ((tal[4] / tal[0]) * 100),
                    ((tal[5] / tal[0]) * 100), ((tal[6] / tal[0]) * 100), ((tal[7] / tal[0]) * 100), ((tal[8] / tal[0]) * 100), ((tal[9] / tal[0]) * 100)));

                Console.WriteLine("Totalt " + tal[0] + " tal");
                Console.WriteLine("\n Vill du få fram html bodien? Klicka enter");


                Console.ReadLine();
                Console.WriteLine(body);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }


        }

        static double[] Kalkylera_FörstaSiffror(string body)
        {

            double[] tal = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            bool mellanrum = false; 

            for (int i = 0; i < body.Length; i++)
            {
                switch (body[i])
                {
                    case '1':
                        if (mellanrum == false)
                        {
                            tal[1]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '2':
                        if (mellanrum == false)
                        {
                            tal[2]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '3':
                        if (mellanrum == false)
                        {
                            tal[3]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '4':
                        if (mellanrum == false)
                        {
                            tal[4]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '5':
                        if (mellanrum == false)
                        {
                            tal[5]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '6':
                        if (mellanrum == false)
                        {
                            tal[6]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '7':
                        if (mellanrum == false)
                        {
                            tal[6]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '8':
                        if (mellanrum == false)
                        {
                            tal[8]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case '9':
                        if (mellanrum == false)
                        {
                            tal[9]++;
                            tal[0]++;
                            mellanrum = true;
                        }
                        break;
                    case ' ':
                        mellanrum = false;
                        break;
                }
            }

            return tal;
        }
    }
}
