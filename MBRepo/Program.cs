using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRepo
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var repo = new Repo<GVentesEntities>();

            //----------------
            //Get COMMANDES
            //----------------
            //var cmds = repo.GetAll<Commande>();
            //foreach (var c in cmds)
            //{
            //    Console.WriteLine($"ID : {c.ID}, Client : {c.CLT}, Total : {c.QTE * c.PRU}");
            //}


            //----------------
            //Get CLIENTS
            //----------------
            //var clts = repo.GetAll<Client>();
            //foreach (var c in clts)
            //{
            //    Console.WriteLine($"Client Name : {c.Nom} {c.Prenom}");
            //}



            //----------------
            //GeT ONE Client
            //----------------
            //var C = repo.GetOne<Client>("CLT-5");
            //Console.WriteLine($"{C.ID} {C.Nom} {C.Prenom} {C.Ville}");




            //-------------------------------------------
            //Insert one client record into a table
            //-------------------------------------------
            //var clt = new Client()
            //          {
            //              ID                = "CLT-XX",
            //              Nom               = "xxxx",
            //              Prenom            = "xxxx",
            //              Ville             = "Agadir",
            //              Date_De_Naissance = DateTime.Today
            //          };

            //repo.Insert(clt);
            //repo.Save();
            //Console.WriteLine("Done !");



            //--------------------------------------------------
            //Insert a range of client records into Client table
            //--------------------------------------------------
            // var clts = new List<Client>()
            //            {
            //                new Client()
            //                {
            //                    ID                = "CLT-X",
            //                    Nom               = "xxxx",
            //                    Prenom            = "xxxx",
            //                    Ville             = "Casa",
            //                    Date_De_Naissance = DateTime.Today
            //                },
            //                new Client()
            //                {
            //                    ID                = "CLT-XX",
            //                    Nom               = "xxxx",
            //                    Prenom            = "xxxx",
            //                    Ville             = "Agadir",
            //                    Date_De_Naissance = DateTime.Today
            //                }
            //            };

            //await repo.InsertRangeAsync(clts);
            // repo.Save();
            // Console.WriteLine("Done !");



            //--------------------------------------------------
            //Get many
            //--------------------------------------------------
            //var R = repo.GetMany<Client>(typeof(Client).GetProperty("Ville").Name, "Agadir");

            //foreach (var c in R)
            //{
            //    Console.WriteLine($"{c.ID} {c.Nom} {c.Ville}");
            //}


            //--------------------------------------------------
            //Contains
            //--------------------------------------------------
            var R = repo.GetOne<Client>("CLT-9");

            Client c = new Client()
                       {
                           ID                = R.ID, Nom = R.Nom, Prenom = R.Prenom, Ville = R.Ville,
                           Date_De_Naissance = R.Date_De_Naissance
                       };

            Console.WriteLine(await repo.ContainsAsync<Client,ClientComparer>(c));

            Console.ReadKey();

        }
    }
}
