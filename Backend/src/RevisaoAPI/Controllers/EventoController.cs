﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoUdemyAPI.Models;

namespace RevisaoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento  = new Evento[]
        {
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1º lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                },                    
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "São Paulo",
                    Lote = "2º lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                }
        };

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
            return _evento.Where(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Verbo HttpPost";
        }

        [HttpPut]
        public string Put()
        {
            return "Verbo HttpPut";
        }

        [HttpPut("{id}")]
        public IEnumerable<Evento> PutById(int id)
        {
            _evento.Where(e => e.EventoId == id);

            return _evento;
        }

        [HttpDelete]
        public string Delete()
        {
            return "Verbo HttpDelete";
        }

        [HttpDelete("{id}")]
        public IEnumerable<Evento> DeleteById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
            
            
        }
    }
}
