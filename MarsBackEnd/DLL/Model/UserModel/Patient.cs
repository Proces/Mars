﻿using System.Drawing.Printing;

namespace DLL.Models.UserModel
{
    public class Patient
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfilePictire { get; set; }
        public List<Apointment> Apointments { get; set; }
        public string MedicineHistory { get; set; }

    }
}
