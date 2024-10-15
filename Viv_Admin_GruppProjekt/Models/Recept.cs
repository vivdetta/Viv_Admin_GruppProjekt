using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viv_Admin_GruppProjekt.Models
{
    public class Recept
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeOfRecept { get; set; }

        // Parameterless constructor
        // This constructor is called when no arguments are passed during object creation.
        // It checks if the Id is not set (Guid.Empty) and generates a new unique Guid for the Id.
        public Recept()
        {
            // Generate a new unique Id only if it's not set
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }

        public Recept(string name, string description, string typeOfRecept)
        {
            Id = Guid.NewGuid();  // Assign a unique Id when a new Recept is created
            Name = name;
            Description = description;
            TypeOfRecept = typeOfRecept;
        }
    }
}
