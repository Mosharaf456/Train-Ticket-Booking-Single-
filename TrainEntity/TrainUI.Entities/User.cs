using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Entities
{
    public class User
    {
        //fields
       private  string username, email, password, dob,gender,confirmPassword,status;
        

        //parameterless constructor
        public User() { }
        //parameterized constructor
        public User(string[] values)
        {
            this.username = values[0];
            this.email = values[1];
            this.password = values[2];
            this.dob = values[3];
            this.gender = values[4];
           // this.confirmPassword = values[5];
           // this.status = values[6];

        }
        /// <summary>
        /// Multiple value receieve and initialize
        /// </summary>
        /// <param name="val"></param>
        public void Save(params string[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                this.username = val[i];
                this.email = val[1];
                this.password = val[2];
                this.dob = val[3];
                this.gender = val[4];
                //this.confirmPassword = val[5];
                //this.status = val[6];
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return confirmPassword;
            }

            set
            {
                confirmPassword = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
