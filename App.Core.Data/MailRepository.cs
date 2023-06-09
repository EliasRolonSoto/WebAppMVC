﻿using App.Core.Entities;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace App.Core.Data
{
    public class MailRepository
    {
       
        public MailRepository()
        {

        }

        public RespuestaGenerica<Mail> Search(BusquedaGenerica<Mail> mailBusqueda)
        {

            var skipRows = ((mailBusqueda.PageIndex - 1) * mailBusqueda.PageSize);

            using (var context = new MailsContext())
            {
                var query = from m in context.Mails
                            where m.Asunto.Contains(mailBusqueda.TextToSearch)
                            select m;

                var contar = query.Count();

                var respuesta = new RespuestaGenerica<Mail>
                {
                    Items = query.Skip(skipRows)
                                          .Take(mailBusqueda.PageSize)
                                          .ToList(),

                    Total = contar
                };


                return respuesta;
            }
            
        }
    }
}