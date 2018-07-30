using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dojodachi.Models;

namespace dojodachi.Controllers
{
    public class HomeController : Controller{

        public static Pet pet = new Pet(){
            happiness = 20,
            fullness = 20,
            energy = 50,
            meal = 3
        };
        public IActionResult Feed(){
           Random rand = new Random();        
            int num = rand.Next(5, 11);
            if(pet.meal >= 1){
                pet.meal -= 1;
                pet.fullness += num;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Play(){
            Random rand = new Random();
            int num = rand.Next(5, 11);
            pet.energy -= 5;
            pet.happiness += num;
            return RedirectToAction("Index");
        }
        public IActionResult Work(){
            Random rand = new Random();
            int num = rand.Next(1, 4);
            pet.energy -= 5;
            pet.meal += num;
            return RedirectToAction("Index");
        }
        public IActionResult Sleep(){
            pet.happiness -= 5;
            pet.energy += 15;
            return RedirectToAction("Index");         
        }
        public IActionResult Restart(){
            pet.happiness = 20;
            pet.fullness = 20;
            pet.energy = 50;
            pet.meal = 3;
            return RedirectToAction("Index");           
        }
        
        public IActionResult Index(){
       // If energy, fullness, and happiness are all raised to over 100, you win!
            if(pet.energy >= 100 && pet.fullness >= 100 && pet.happiness >= 100){
                return RedirectToAction("Win");
            }
            // If fullness or happiness ever drop to 0, you lose, and a restart button should be displayed.
            if(pet.fullness <= 0 || pet.happiness <= 0){
                return RedirectToAction("Passed");
            }
            return View(pet);
        }

        public IActionResult Win(){
            ViewData["Message"] = "Congradulations! You won!";
            
            return View(pet);
        }

        public IActionResult Passed(){
            ViewData["Message"] = "Your Dojodochi has passed away";
            return View(pet);
        }

        public IActionResult Privacy(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}