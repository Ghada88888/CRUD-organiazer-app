

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;



namespace test_technique_app.models
{
    public class choix
    {
        [Key]

        public int Id { get; set; }

        public string login { get; set; }
        public string pwd { get; set; }
        public string email { get; set; }
    }


}
    

