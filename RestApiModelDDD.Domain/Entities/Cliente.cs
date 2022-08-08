using System;

namespace RestApiModelDDD.Domain.Entities
{
    public class Cliente : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public bool IsActive { get; set; }


    }
}
