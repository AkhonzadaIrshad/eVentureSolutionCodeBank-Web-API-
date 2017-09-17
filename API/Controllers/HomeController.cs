using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        
    }

   public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
    public class HomeController : ApiController
    {

        public static List<Student> Students = new List<Student>();

        [HttpGet]
        public IHttpActionResult Get()
        {

            return Ok(Students);


            //return Ok(new Student()
            //{
            //    Id = 123,Name = "First Student",
            //   Address = new Address()
            //   {
            //       City = "Lahore",
            //       Street = "Street One"
            //   }
            //});


        }

        [HttpPost]
        public IHttpActionResult Add(Student student)
        {
            try
            {
                Students.Add(student);
                return Ok("Success");
            }
            catch (Exception e)
            {
                return Ok($"Failed to Add due to {e.Message}");
            } 
           
           
        }

        //[HttpGet]
        //public IHttpActionResult Add(string Name, string Id, string Street, string City)
        //{
        //    try
        //    {
        //        Students.Add(new Student()
        //        {
        //            Name = Name,
        //            Id = Convert.ToInt32(Id),
        //            Address = new Address()
        //            {
        //                Street = Street,
        //                City = City
        //            }
        //        });
        //        return Ok("Success");
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok($"Failed to Add due to {e.Message}");
        //    }


        //}


    }
}
