﻿using System;
namespace Лабораторная_1.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string NameRole { get; set; }
        public Role() { }
        public Role(int id, string nameRole)
        {
            this.Id = id;
            this.NameRole = nameRole;
        }
        public Role ShallowCopy()
        {
            return (Role)this.MemberwiseClone();
        }


    }
}