﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    //实体

    public class Person
    {
        public Person()
        {
            Address = new Address();
            Info = new PersonalInfo()
            {
                Weight = new Measurement(),
                Height = new Measurement()
            };
        }

        public int PersonId { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public byte[] Photo { get; set; }
        public PersonalInfo Info { get; set; }
        public byte[] RowVersion { get; set; }

        public List<Lodging> PrimaryContactFor { get; set; }

        public List<Lodging> SecondaryContactFor { get; set; }


    }
}
