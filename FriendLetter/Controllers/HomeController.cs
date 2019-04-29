using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "goodbye friend."; }

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient("Jessica");
            myLetterVariable.SetSender("Robert");
            return View(myLetterVariable);
        }

        [Route("/journal")]
        public ActionResult Journal() { return View(); }

        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/postcard")]
        public ActionResult PostCard(string recipient, string sender)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(recipient);
            myLetterVariable.SetSender(sender);
            return View(myLetterVariable);
        }
    }
}