using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using App.Core.Business;
using App.Core.Entities;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private MailBusiness _mailBusiness;

        public MailController(MailBusiness mailBusiness)
        {
            _mailBusiness = mailBusiness;
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<App.Core.Entities.Mail> Get()
        {

            var emails = new List<App.Core.Entities.Mail>();

            emails.Add(new App.Core.Entities.Mail()
            {
                MailId = 1,
                Asunto = "Demo"
            });

            return emails;
        }


        [HttpGet("{emailId:int}")]
        public App.Core.Entities.Mail GetMail(int emailId)
        {
            if (emailId <= 0)
            {
                BadRequest("Debe enviar un identificador valido");
            }

            var email1 = new App.Core.Entities.Mail()
            {
                MailId = emailId,
                Asunto = $"Demo {emailId}",
                Contenido = $"este es el contendido del mail {emailId}"
                
            };

            return email1;
        }


        [HttpGet("{emailId:int}/personalizado")]
        public App.Core.Entities.Mail GetMail2(int emailId)
        {
            if (emailId <= 0)
            {
                BadRequest("Debe enviar un identificador valido");
            }

            var email1 = new App.Core.Entities.Mail()
            {
                MailId = emailId,
                Asunto = $"Demo {emailId}"
            };

            return email1;
        }




        [HttpPost]
        public IActionResult Post(App.Core.Entities.Mail mail)
        {
            //_emailBusinness.IsValid(mail);


            if (mail is null)
            {
                return BadRequest();
            }

            var demoAsunto = mail.Asunto;

            return new OkResult();
        }


        [EnableCors]
        [HttpPost("search")]
        public IActionResult Search([FromBody] BusquedaGenerica<Mail> mailBusqueda)
        {

            if (mailBusqueda is null
                || !mailBusqueda.IsValid)
            {
                return BadRequest();
            }


            ///Request.Form[]

            var respuesta = _mailBusiness.Search(mailBusqueda);

            //Response.StatusCode = 200;
            //Response.Body

            return Ok(respuesta);
        }

        [EnableCors]
        [HttpGet("search2")]
        public IActionResult Search2([FromQuery] BusquedaGenerica<Mail> mailBusqueda)
        {

            if (mailBusqueda is null
                || !mailBusqueda.IsValid)
            {
                return BadRequest();
            }


            ///Request.Form[]

            var respuesta = _mailBusiness.Search(mailBusqueda);

            return Ok(respuesta);
        }


    }
}
