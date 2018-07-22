using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Any_Shop.Models
{
    public class Make
    {
        public int id{get; set;}
        public string Name{get; set;}

        public ICollection<Model> Models{get;set;}

        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}