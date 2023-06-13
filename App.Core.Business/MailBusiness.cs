using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business
{
    public class MailBusiness
    {
        private MailRepository _mailRepository;
        private ContactRepository _contactRepository;


        public MailBusiness(MailRepository mailRepository,
                            ContactRepository contactRepository)
        {
            _mailRepository = mailRepository;
            _contactRepository = contactRepository;
        }


        public RespuestaGenerica<Mail> Search(BusquedaGenerica<Mail> mailBusqueda)
        {
            //TODO: Validar textToSearch, pageIndex
            if (mailBusqueda is null)
            {
                throw new ArgumentException("Filter invalid");
            }

            //TODO: Paginar

            return _mailRepository.Search(mailBusqueda);
        }

        //public List<Mail> Search(MailFilter filter)
        //{

        //    //TODO: Validar textToSearch, pageIndex
        //    if (filter is null)
        //    {
        //        throw new ArgumentException("Filter invalid");
        //    }

        //    //TODO: Paginar

        //    //return _mailRepository.Search(textToSearch,
        //    //                              pageSize,
        //    //                              pageIndex);
        //    return _mailRepository.Search(filter.TextToSearch,
        //                                  filter.PageSize,
        //                                  filter.PageIndex);
        //}

    }
}