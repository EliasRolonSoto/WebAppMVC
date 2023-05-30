using App.Core.Entities;
using RepoDb;

namespace App.Core.Data
{
    public class MailRepository
    {
        private string _connectionString =
                "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";
        public MailRepository()
        {
            GlobalConfiguration
              .Setup()
              .UseSqlServer();
        }

        public IEnumerable<Mail> Search(){

            IEnumerable<Mail> mails;



            return mails;
        }
    }
}