﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace PortalConhecimento.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            this.Experiencias = new HashSet<Experiencia>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string TaxId { get; set; }

        public bool Enabled { get; set; }

        public string IPAddress { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<Experiencia> Experiencias { get; set; }
    }
}