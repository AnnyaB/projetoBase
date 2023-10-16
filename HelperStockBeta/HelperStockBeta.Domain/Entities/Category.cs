﻿using HelperStockBeta.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        //relação de entidades
        public ICollection<Product> Products { get; set; }

        public Category(string name)
        {
            ValidateDomain(name);
            Name = name;
        }
        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Identification is positive values!");
            Id = id;
            ValidateDomain(name);
            Name = name;
        }
        public void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required!");
            DomainExceptionValidation.When(name.Length > 3, "Name is minimn 3 characters");
        }
    }
}
