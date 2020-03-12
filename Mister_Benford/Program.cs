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

            Console.WriteLine(FiggleFonts.Pawp.Render("Benfords Lag"));


            double ettor = 0;
            double tvåor = 0;
            double treor = 0;
            double fyror = 0;
            double femmor = 0;
            double sexor = 0;
            double sjuor = 0;
            double åttor = 0;
            double nior = 0;

            double totalt = 0;

            bool mellanrum = false;

            //Felhantering
            try
            {
                //Knappa in urlen
                string url = "din länk";

                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(url);

                var htmlbody = doc.DocumentNode.SelectSingleNode("//body");


                string body = htmlbody.InnerText;


                for (int i = 0; i < body.Length; i++)
                {
                    switch (body[i])
                    {
                        case '1':
                            if (mellanrum == false)
                            {
                                ettor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '2':
                            if (mellanrum == false)
                            {
                                tvåor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '3':
                            if (mellanrum == false)
                            {
                                treor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '4':
                            if (mellanrum == false)
                            {
                                fyror++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '5':
                            if (mellanrum == false)
                            {
                                femmor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '6':
                            if (mellanrum == false)
                            {
                                sexor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '7':
                            if (mellanrum == false)
                            {
                                sjuor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '8':
                            if (mellanrum == false)
                            {
                                åttor++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case '9':
                            if (mellanrum == false)
                            {
                                nior++;
                                totalt++;
                                mellanrum = true;
                            }
                            break;
                        case ' ':
                            mellanrum = false;
                            break;
                    }
                }


                Console.WriteLine(string.Format(" Antalet ettor: {0} \n Antalet tvåor: {1} \n Antalet treor: {2} \n Antalet fyror: {3} \n Antalet femmor: {4} \n Antalet sexor: {5} \n Antalet sjuor: {6} \n Antalet åttor: {7} \n Antalet nior: {8} \n", ettor, tvåor, treor, fyror, femmor, sexor, sjuor, åttor, nior));
                Console.WriteLine(string.Format(" Antalet ettor: {0} \n Antalet tvåor: {1} \n Antalet treor: {2} \n Antalet fyror: {3} \n Antalet femmor: {4} \n Antalet sexor: {5} \n Antalet sjuor: {6} \n Antalet åttor: {7} \n Antalet nior: {8} \n",
                    (double)((ettor / totalt) * 100), ((tvåor / totalt) * 100), ((treor / totalt) * 100), ((fyror / totalt) * 100),
                    ((femmor / totalt) * 100), ((sexor / totalt) * 100), ((sjuor / totalt) * 100), ((åttor / totalt) * 100), ((nior / totalt) * 100)));

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
    }
}
