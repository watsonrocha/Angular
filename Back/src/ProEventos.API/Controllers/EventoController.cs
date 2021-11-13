using ProEventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    
                    EventoId = 1,
                    Tema = "Angular 12 e NET 5",
                    Local = "Sorocaba",
                    lote = "1º Lote",
                    QtdePessoas =250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                 new Evento(){
                    
                    EventoId = 2,
                    Tema = "Angular  suas novidades",
                    Local = "Vptprantim",
                    lote = "2º Lote",
                    QtdePessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString()
                }
               

            };
   
        private readonly ILogger<EventoController> _logger;

        public EventoController()
        {    
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {          
            return _evento;
                           
        }
         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {          
            return  _evento.Where(evento => evento.EventoId == id);
                           
        }

        [HttpPost]
        public string Post(){
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Exemplo de Put com id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
