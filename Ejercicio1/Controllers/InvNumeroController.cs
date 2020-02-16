using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
    public class InvNumeroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new InvertirNumero());
        }

        [HttpPost]
        public IActionResult Index(InvertirNumero i, string inversion)
        {
            if (inversion == "inv")
            {
                i.InvNum = Invertir(i.Num).ToString("D2");
            }

            return View(i);
        }

        private int Invertir(int num)
        {
            int resul = 0; 

            while (num > 0) 
            { 
                resul = resul * 10 + num % 10; num /= 10;
            }

            return resul;
        }
    }
}