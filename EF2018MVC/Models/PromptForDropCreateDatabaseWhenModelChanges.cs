using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF2018MVC.Models
{
    //custom initializer. veikia tik ant console pasirasius programa.
    public class PromptForDropCreateDatabaseWhenModelChanges<TContext> : IDatabaseInitializer<TContext> where TContext : DbContext
    {
        public void InitializeDatabase(TContext context)
        {
            //If the database exists and matches the model
            //there is nothing to do
            var exists = context.Database.Exists();
            if (false && context.Database.CompatibleWithModel(true))
            {
                return;
            }
            if (exists)
            {
                Console.WriteLine("Exsisting database dosen't match the model!");
                Console.Write("Do you want to drop and create the database? (Y/N): ");
                var res = Console.ReadKey();
                Console.WriteLine();
                if (!String.Equals("Y", res.KeyChar.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
                context.Database.Delete();
            }
            //Database either did'n exist or it didn't match
            //the model and the user chose to delete it
            context.Database.Create();
        }
    }
}