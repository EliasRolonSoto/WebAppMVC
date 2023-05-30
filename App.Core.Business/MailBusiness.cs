using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business
{
    public class MailBusiness
    {
        public MailBusiness()
        {

        }

        public List<Mail> Search(string text)
        {
            return MailRepository.Search();
        }
    }
}