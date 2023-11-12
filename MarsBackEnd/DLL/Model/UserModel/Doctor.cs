﻿namespace DLL.Models.UserModel
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Job {  get; set; }
        public DateTime DAteOfBirth { get; set; }
        public string ProfilePicture { get; set; }
        public List<Apointment> Apointment { get; set; }
    }
}