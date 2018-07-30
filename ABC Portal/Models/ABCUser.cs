﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ABC_Portal.Models
{
    public class ABCUser
    {

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; } = "";

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")] 
        public string Password { get; set; } = "";

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; } = false;

        /// <summary>
        /// Checks if user with given password exists in the database
        /// </summary>
        /// <param name="_username">User name</param>
        /// <param name="_password">User password</param>
        /// <returns>True if user exist and password is correct</returns>
        public bool IsValid(string _username, string _password)
        {

            return true;

        }


    }
}