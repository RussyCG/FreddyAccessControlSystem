using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Representation of a user that manages the Access Control System from the Database
    /// </summary>
    public class AdminUser
    {
        #region Fields

        private int id;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string contactNumber;
        private string username;
        private string password;

        #endregion

        #region Constructors

        /// <summary>
        /// Generic Constructor
        /// </summary>
        public AdminUser()
        {

        }

        /// <summary>
        /// Initialise the Admin User without an ID
        /// </summary>
        /// <param name="FirstNameParam"> First name of the User</param>
        /// <param name="LastNameParam">Surname of the User</param>
        /// <param name="EmailAddressParam">Email Address to contact the user</param>
        /// <param name="ContactNumberParam">Telephone Number to contact the user</param>
        /// <param name="UsernameParam">Unique username for user</param>
        /// <param name="PasswordParam">Confidential Password linked to the users account to verify access</param>
        public AdminUser(string FirstNameParam, string LastNameParam, string EmailAddressParam, string ContactNumberParam, string UsernameParam, string PasswordParam)
        {
            InitializeComponent(FirstNameParam, LastNameParam, EmailAddressParam, ContactNumberParam, UsernameParam, PasswordParam);
        }

        /// <summary>
        /// Initialise the AdminUser with full parameters
        /// </summary>
        /// <param name="FirstNameParam"> First name of the User</param>
        /// <param name="LastNameParam">Surname of the User</param>
        /// <param name="EmailAddressParam">Email Address to contact the user</param>
        /// <param name="ContactNumberParam">Telephone Number to contact the user</param>
        /// <param name="UsernameParam">Unique username for user</param>
        /// <param name="PasswordParam">Confidential Password linked to the users account to verify access</param>
        /// <param name="IDParam">Unique ID of the user in the database</param>
        public AdminUser(int IDParam, string FirstNameParam, string LastNameParam, string EmailAddressParam, string ContactNumberParam, string UsernameParam, string PasswordParam)
        {
            InitializeComponent(FirstNameParam, LastNameParam, EmailAddressParam, ContactNumberParam, UsernameParam, PasswordParam, IDParam);
        }

        /// <summary>
        /// Method to set all data from constructor
        /// </summary>
        /// <param name="FirstNameParam"> First name of the User</param>
        /// <param name="LastNameParam">Surname of the User</param>
        /// <param name="EmailAddressParam">Email Address to contact the user</param>
        /// <param name="ContactNumberParam">Telephone Number to contact the user</param>
        /// <param name="UsernameParam">Unique username for user</param>
        /// <param name="PasswordParam">Confidential Password linked to the users account to verify access</param>
        /// <param name="IDParam">Unique ID of the user in the database</param>
        private void InitializeComponent(string FirstNameParam, string LastNameParam, string EmailAddressParam, string ContactNumberParam, string UsernameParam, string PasswordParam, int IDParam = -1)
        {
            this.ID = IDParam;
            this.FirstName = FirstNameParam;
            this.LastName = LastNameParam;
            this.EmailAddress = EmailAddressParam;
            this.ContactNumber = ContactNumberParam;
            this.Username = UsernameParam;
            this.Password = PasswordParam;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Password used to authenticate user
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Unique Username for the Admin User to identify themselves
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Telephone Number of the Admin User, Accepts South African Numbers of International Numbers including the country code
        /// </summary>
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        /// <summary>
        /// Email Address of the Admin user, to be used for contact
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        /// <summary>
        /// Surname of the Admin User
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// First name of the AdminUser
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Unique ID of the AdminUser
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        #endregion
    }
}
