using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace groupactivity.Controllers
{
    public class PracticeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index(){
            return "Hello Wasdasdorld";
        }

        [HttpGet]
        [Route("/myage/{age}")]

        public string ReturnAge(int age)
        {
            return $"Your age is {age}";
        }

        [HttpGet]
        [Route("/myName/{name}")]
        public string ReturnName(string name)
        {
            return $"Your name is {name}";
        } 

        [HttpGet]
        [Route("/{age}/{name}/{color}")]
        
        public object ReturnErrything(int age, string name, string color)
        {
            Dictionary<object,object> holder = new Dictionary<object, object>();
            holder.Add("Name", name);
            holder.Add("Age", age);
            holder.Add("Color",color);
            return holder;

        }
    }

}