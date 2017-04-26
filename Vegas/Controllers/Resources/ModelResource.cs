using Vegas.Models;

namespace Vegas.Controllers.Resources
{
    public class ModelResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //THIS INVERSE RELATIONSHIP IS CAUSING THE LOOP
        //WE DONT WANT A LOOP IN JSON OBJECTS
        //public Make Make { get; set; } 
        //public int MakeId { get; set; }
    }
}